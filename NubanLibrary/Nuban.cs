using System;
using System.Collections.Generic;
using System.Text;

namespace NubanLibrary
{
    public class Nuban
    {
        private static readonly string nubanChecker = "373373373373";

        public static bool ValidateNubanAccount(string accountNumber, string bankCode)
        {
            bool isValid = false;
            if (accountNumber.Length != 10)
                return isValid;
            if(bankCode.Trim().Length == 3 && accountNumber.Trim().Length == 10)
            {
                string nuban = string.Format("{0}{1}", bankCode, accountNumber.Remove(9, 1));
                var checkDigit = Convert.ToInt32(accountNumber.Substring(9, 1));
                int nubanSum = 0;
                for(int i = 0; i < nuban.Length; i++)
                {
                    nubanSum += Convert.ToInt32(nuban[i].ToString()) * Convert.ToInt32(nubanChecker.Substring(i, 1));
                }
                int calCheckDigit = 10 - (nubanSum % 10);
                calCheckDigit = calCheckDigit != 10 ? calCheckDigit : 0;
                isValid = checkDigit == calCheckDigit;
            }
            return isValid;
        }

        public static string GenerateNubanAccount(string serial, string bankCode)
        {
            serial = serial.PadLeft(9, '0');
            string nuban = bankCode + serial;
            int nubanSum = 0;
            for (int i = 0; i < nuban.Length; i++)
            {
                nubanSum += Convert.ToInt32(nuban[i].ToString()) * Convert.ToInt32(nubanChecker.Substring(i, 1));
            }
            int calCheckDigit = 10 - (nubanSum % 10);
            return serial + calCheckDigit;
        }
    }
}
