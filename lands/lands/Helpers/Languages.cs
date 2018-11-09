using System;
using System.Collections.Generic;
using System.Text;

namespace lands.Helpers
{
    using Xamarin.Forms;
    using Interfaces;
    using Properties;

    public static class Languages
    {
        static Languages()
        {
            var ci = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
            Resources.Culture = ci;
            DependencyService.Get<ILocalize>().SetLocale(ci);
        }

        public static string Accept
        {
            get { return Resources.Accept; }
        }

        public static string EmailValidation
        {
            get { return Resources.EmailValidation; }
        }

        public static string Error
        {
            get { return Resources.Error; }
        }

        /*public static string EmailPlaceHolder
        {
            get { return Resources.EmailPlaceHolder; }
        }

        public static string Rememberme
        {
            get { return Resources.Rememberme; }
        }

        public static string PasswordValidation
        {
            get { return Resources.PasswordValidation; }
        }

        public static string SomethingWrong
        {
            get { return Resources.SomethingWrong; }
        }

        public static string Login
        {
            get { return Resources.Login; }
        }

        public static string EMail
        {
            get { return Resources.EMail; }
        }

        public static string Password
        {
            get { return Resources.Password; }
        }

        public static string PasswordPlaceHolder
        {
            get { return Resources.PasswordPlaceHolder; }
        }

        public static string Forgot
        {
            get { return Resources.Forgot; }
        }

        public static string Register
        {
            get { return Resources.Register; }
        }

        public static string Countries
        {
            get { return Resources.Countries; }
        }

        public static string Search
        {
            get { return Resources.Search; }
        }

        public static string Country
        {
            get { return Resource.Country; }
        }

        public static string Information
        {
            get { return Resource.Information; }
        }

        public static string Capital
        {
            get { return Resource.Capital; }
        }

        public static string Population
        {
            get { return Resource.Population; }
        }

        public static string Area
        {
            get { return Resource.Area; }
        }

        public static string AlphaCode2
        {
            get { return Resource.AlphaCode2; }
        }

        public static string AlphaCode3
        {
            get { return Resource.AlphaCode3; }
        }

        public static string Region
        {
            get { return Resource.Region; }
        }

        public static string Subregion
        {
            get { return Resource.Subregion; }
        }

        public static string Demonym
        {
            get { return Resource.Demonym; }
        }

        public static string GINI
        {
            get { return Resource.GINI; }
        }

        public static string NativeName
        {
            get { return Resource.NativeName; }
        }

        public static string NumericCode
        {
            get { return Resource.NumericCode; }
        }

        public static string CIOC
        {
            get { return Resource.CIOC; }
        }

        public static string Borders
        {
            get { return Resource.Borders; }
        }

        public static string Currencies
        {
            get { return Resource.Currencies; }
        }

        public static string MyLanguages
        {
            get { return Resource.MyLanguages; }
        }*/
    }
}
