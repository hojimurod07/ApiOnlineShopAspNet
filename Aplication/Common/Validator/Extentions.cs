using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Aplication.Common.Validator
{
    public static class Extentions
    {
        public static string GetErrorMessages(this ValidationResult result)
        {
            var res = new StringBuilder();
            foreach (var error in result.ErrorMessage)
            {
                res.Append(error.ToString());
            }
            return res.ToString();
        }
    }
}
