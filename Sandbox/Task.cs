using System;
using System.Collections;
using System.Text;

namespace Sandbox
{
    class Task
    {
        public static int Solution(int n)
        {
            StringBuilder binary = new StringBuilder(Convert.ToString(n, 2));

            if (binary.Length > 2)
            {
                ArrayList lenghtsOfBinaryGaps = new ArrayList();

                for (int i = 0; i < binary.Length; i++)
                {
                    if (binary[i].Equals('1') && i+1 < binary.Length && binary[i + 1].Equals('0'))
                    {
                        int lenghtOfBinaryGap = 0;

                        for (int j = i + 1; j < binary.Length; j++)
                        {

                            if (binary[j].Equals('0'))
                            {
                                lenghtOfBinaryGap++;
                                i++;

                            }

                            else
                            {
                                lenghtsOfBinaryGaps.Add(lenghtOfBinaryGap);
                                break;
                            }

                        }

                    }

                }

                if(lenghtsOfBinaryGaps.Count > 0)
                {
                    lenghtsOfBinaryGaps.Sort();
                    lenghtsOfBinaryGaps.Reverse();

                    return (int)lenghtsOfBinaryGaps[0];
                }
                
                else
                {
                    return 0;
                }

            } else

            {
                return 0;
            }

            
        }
    }
}
