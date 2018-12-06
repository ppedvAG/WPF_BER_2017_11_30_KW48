using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Validierung
{
    class IpValidierung : ValidationRule
    {
        //ValidationRules müssen von der Klasse ValidationRule erben und die abstrakte Methode Validate() implementieren.
        //Diese liefert ein ValidationResult zurück, je nachdem, ob die Regel erfüllt wurde oder nicht.
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            //return Regex.IsMatch(value.ToString(), @"((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)") ?
            //    ValidationResult.ValidResult : new ValidationResult(false, "Gib eine IP-Adresse ein!");

            if( Regex.IsMatch(value.ToString(), @"^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$"))
            {
                return ValidationResult.ValidResult;
            }
            else
            {
                return new ValidationResult(false, "Bitte gib eine valide IP-Adresse ein");
            }

        }
    }
}
