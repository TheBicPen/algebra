using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Algebra
{
    class Expression
    {
        private string ExpressionString = "";
        private readonly string[] operatorList = { "*", "/", "+", "-", "(", ")", "^", "//" };

        public Expression(string ES)
        {
            ExpressionString = ES; //same as this.ExpressionString = ES
        }

        public int Evaluate()
        {
            return 0;
        }

        //splits an expression into list of terms and operators, preserving their order
        private List<string> SplitValues(string es) //idk how to get expression string
        { 
            List<string> terms = new List<string>();
            char[] chars = es.ToCharArray();
            terms.Add(chars[0].ToString());
            for(int i=1;i<chars.Length;i++)
            {
                if (char.IsDigit(chars[i]) && char.IsDigit(chars[i-1]) || 
                    operatorList.Contains(chars[i].ToString()) && operatorList.Contains(chars[i-1].ToString()))
                {
                    terms[i - 1] += chars[i];
                }
                else
                {
                    terms.Add(chars[i].ToString());
                }
            }
            return terms;
        }
       

    }
}
