using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechanicMonke
{
    internal class StringPrompt
    {
        public static string Prompt(string message)
        {
            StringPromptBox stringPromptBox = new StringPromptBox(message);
            stringPromptBox.ShowDialog();

            while (stringPromptBox.Output == "")
            {
                Task.Delay(100);
            }

            return stringPromptBox.Output;
        }
    }
}
