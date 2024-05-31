using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Windows.Forms;
namespace Lab_1_Ilchenko_Control_lib
{
    using System;
    using System.Windows.Forms;


    [ToolboxBitmap(typeof(DataSizeTextBox), "Lab_1_Ctrl.bmp")]
    public class DataSizeTextBox : TextBox
    {

        public long DataSizeInBytes { get; private set; }


        public event Action<long> DataSizeChanged;

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
           
            string convertedText = ConvertToBytes(Text);
            if (long.TryParse(convertedText, out long dataSize))
            {
                DataSizeInBytes = dataSize;
                DataSizeChanged?.Invoke(dataSize);
            }
       
        }

        private string ConvertToBytes(string input)
        {
            try
            {
                string[] parts = input.Split(' ');
                if (parts.Length <3 ) { return Text; }
                if (parts.Length == 3)
                {


                    if (!long.TryParse(parts[0], out long value))
                        return "Неправильне число. Введіть коректне число.";

                    string unit = parts[1].ToLower();

                    switch (unit)
                    {
                        case "b":
                            return value.ToString();
                        case "kb":
                            return (value * 1024).ToString();
                        case "mb":
                            return (value * 1024 * 1024).ToString();
                        case "gb":
                            return (value * 1024 * 1024 * 1024).ToString();
                        default:
                            return "Неправильна одиниця виміру. Використовуйте 'b', 'kb', 'mb' або 'gb'.";
                    }
                }
                else
                {
                    return "";
                }
            }
            catch (Exception ex)
            {
                return $"Сталася помилка: {ex.Message}";
            }
            
        }
    }
}
