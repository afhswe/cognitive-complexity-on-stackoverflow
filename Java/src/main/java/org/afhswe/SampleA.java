package org.afhswe;

import com.google.common.primitives.Ints;

public class SampleA
{
    // Total cognitive complexity: 9
    public char findDelimiter(String fieldseparator)
    {
        char delim = '\0';
        if (fieldseparator != null // +1 for the if condition
                && !fieldseparator.isEmpty()) { // +1 for the binary operator
            if (fieldseparator.equals("\\t")) { // +2 for the nested if (nesting = 1)
                delim = '\t';
            } else { // +1 for else
                // handling unicode separator
                Integer i = Ints.tryParse(fieldseparator);
                if (i != null) { // +3 for the double nested if (nesting = 2)
                    fieldseparator = String.valueOf(Character.toChars(i));
                    delim = fieldseparator.charAt(0);
                } else { // +1 for the else
                    delim = fieldseparator.charAt(0);
                }
            }
        }
        return delim;
    }
}
