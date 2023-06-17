using SALES.Model;
using SALES.Types;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SALES.ViewModels
{
    public class SalesViewModel
    {
        public SalesViewModel() { }

        public async Task<string> GetOutput(string input)
        {
            if (input == "")
            {
                return "Please insert input";
            }

            try
            {
                input = input.ToLower();

                List<SalesModel> salesModels = await GetAllSalesList(input);
                List<SalesModel> salesModelBTs = await CheckBasicSalesTax(salesModels);
                List<SalesModel> salesModelIDutys = await CheckImportDuty(salesModelBTs);
                string output = await ChangeModelToString(salesModelIDutys);

                return output;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<List<SalesModel>> GetAllSalesList(string input)
        {
            List<SalesModel> salesModels = new List<SalesModel>();
            int countId = 0;

            List<string> salesString = input.Split('\n').Where(x => x != "").ToList();

            foreach (var sales in salesString)
            {
                string[] salesSplitted = sales.Split(' ');

                if (int.Parse(salesSplitted[0]) == 0)
                {
                    throw new Exception("Non inserire 0 come quantità del prodotto.");
                }

                int quantity = int.Parse(salesSplitted[0]);
                bool imported = sales.Contains("imported") == true ? true : false;
                decimal price = decimal.Parse(salesSplitted[salesSplitted.Length - 1].Replace(".", ","));
                string objectString = sales.Replace(salesSplitted[0] + " ", "")
                                           .Replace(salesSplitted[salesSplitted.Length - 1], "")
                                           .Replace(" at ", "");
                if (imported)
                {
                    objectString = objectString.Replace("imported ", "");
                }

                salesModels.Add(new SalesModel
                {
                    Id = countId,
                    Quantity = quantity,
                    Imported = imported,
                    Object = objectString,
                    Price = price
                });

                countId++;
            }

            return salesModels;
        }

        public async Task<List<SalesModel>> CheckBasicSalesTax(List<SalesModel> salesModels)
        {
            BookType bookType = new BookType();
            FoodType foodType = new FoodType();
            MedicalType medicalType = new MedicalType();

            foreach (var sales in salesModels)
            {
                if (bookType.Books.Any(sales.Object.Contains) == false
                 && foodType.Foods.Any(sales.Object.Contains) == false
                 && medicalType.Medicals.Any(sales.Object.Contains) == false)
                {
                    sales.Tax = (sales.Price * 10) / 100;
                }
                else
                {
                    sales.Tax = 0;
                }
            }

            return salesModels;
        }

        public async Task<List<SalesModel>> CheckImportDuty(List<SalesModel> salesModels)
        {
            foreach (var sales in salesModels)
            {
                if (sales.Imported == true)
                {
                    sales.Tax += (sales.Price * 5) / 100;
                }

                sales.Tax = Math.Ceiling(sales.Tax * 20) / 20;
            }

            return salesModels;
        }

        public async Task<string> ChangeModelToString(List<SalesModel> salesModels)
        {
            string output = null;
            decimal sumTax = 0;
            decimal sumPrice = 0;

            foreach (var sales in salesModels)
            {
                output += sales.Quantity.ToString() + " ";
                output += sales.Imported == true ? "imported " : "";
                output += sales.Object.ToString() + ": ";
                output += ((sales.Price * sales.Quantity) + (sales.Tax * sales.Quantity)).ToString() + "\n";

                sumTax += sales.Tax * sales.Quantity;
                sumPrice += (sales.Price * sales.Quantity) + (sales.Tax * sales.Quantity);
            }

            output += "Sales Taxes: " + sumTax + "\n";
            output += "Total: " + sumPrice;

            return output;
        }
    }
}
