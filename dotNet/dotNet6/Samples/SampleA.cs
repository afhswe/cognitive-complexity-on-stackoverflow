using System;
using System.Linq;

namespace CognitiveComplexityOnStackOverflow
{
    public class SampleA
    {
        // Total cognitive complexity: 9
        public char FindDelimiter(string fieldseparator)
        {
            char delim = '\0';
            if (fieldseparator != null // +1 for the if condition
                && !string.IsNullOrEmpty(fieldseparator)) // +1 for the binary operator
            { 
                if (fieldseparator == "\\t") // +2 for the nested if (nesting = 1)
                { 
                    delim = '\t';
                }
                else // +1 for else
                { 
                    // handling unicode separator
                    if(int.TryParse(fieldseparator, out int value))
                    {
                        fieldseparator = Convert.ToString(value);
                        delim = fieldseparator.ElementAt(0);
                    }
                    else
                    { // +1 for the else
                        delim = fieldseparator.ElementAt(0);
                    }
                }
            }
            return delim;
        }
    }
}
