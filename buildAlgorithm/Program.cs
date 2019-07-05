using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buildAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
           // var list = new List<string> { "a", "a", "a", "a", "b", "b", "b", "c", "d", "e" };
            var list = new List<string> { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "b","b", "b", "b", "b", "b", "b", "b", "c", "c", "c", "c", "c", "c", "c", "c", "c", "c", "c", "c", "c", "d", "d", "d", "d", "e", "e", "e", "e", "e", "e", "e", "e" };

            //var result = GetPermutations(list, 3);
            //foreach (var perm in result)
            //{
            //    foreach (var c in perm)
            //    {
            //        Console.Write(c + " ");
            //    }
            //    Console.WriteLine();
            //}
            allCombinations(list);

            //foreach (string li in convertList(list, 3))
            //{
            //    Console.WriteLine(li);
            //}
            Console.ReadKey();
        }

        static List<string> convertList(List<string> li , int p)
        {
            List<string> cList = new List<string>();
            int duplicate = 0;
            for(int i = 0; i< li.Count; i++)
            {
                if(i == 0)
                {
                    cList.Add(li[i]);
                }
                else if (i > 0)
                {
                    if (li[i] == li[i-1])
                    {
                        duplicate++;
                    }
                    else
                    {
                        duplicate = 0;
                    }
                    if (duplicate < p-1)
                    {
                        cList.Add(li[i]);
                    }
                   
                }
                
            }

            return cList;
        }

        static void allCombinations(List<string> li)
        {
            int rreshta = 0;
            for (int k = 2; k <= li.Count; k++)
            {
                var result = GetPermutations(li, k);
                foreach (var perm in result)
                {
                    //Console.WriteLine(perm);
                    foreach (var c in perm)
                    {
                        //Console.WriteLine(c);
                       Console.Write(c + " ");
                    }
                    rreshta++;
                Console.WriteLine();
                //Console.WriteLine("*********************");
                //Console.WriteLine("*********************");
                //Console.WriteLine("*********************");

            }
            }
            Console.WriteLine(rreshta);
        }

        static IEnumerable<IEnumerable<T>> GetPermutations<T>(IEnumerable<T> items, int count)
        {
            int i = 0;
            foreach (var item in items)
            {
                //Console.WriteLine("{{{{{{{{{{{{{{");
            
                if (count == 1)
                    yield return new T[] { item };
                else
                {
                    var getIndex = items.ToArray();
                    foreach (var result in GetPermutations(items.Skip(i + 1), count - 1))
                    {
                        //foreach (var it in items)
                        // Console.WriteLine(it);
                        //Console.WriteLine("+++++++++++++++++++++++++++");
                        //foreach (var r in result)
                        //Console.WriteLine(r);
                        //Console.WriteLine("--------------------------");
                        
                        //    Console.WriteLine(i);
                        //Console.WriteLine("####################################");
                        if (i>0 ) {
                            //Console.WriteLine(getIndex[i].ToString() + " Current" );
                            //Console.WriteLine(getIndex[i-1].ToString() + "Mrapa");
                            //Console.WriteLine(getIndex[i+1].ToString() + " Para");

                            if (getIndex[i].ToString() != getIndex[i - 1].ToString() && getIndex[i].ToString() != getIndex[i + 1].ToString())
                            {
                                //Console.WriteLine("sent");

                                yield return new T[] { item }.Concat(result);
                            }
                            else if(getIndex[i].ToString() != getIndex[i - 1].ToString() && getIndex[i].ToString() == getIndex[i + 1].ToString())
                            {
                                //Console.WriteLine("sent");

                                yield return new T[] { item }.Concat(result);
                            }
                            else if (getIndex[i].ToString() == getIndex[i - 1].ToString() && getIndex[i].ToString() != getIndex[i + 1].ToString())
                            {
                                //Console.WriteLine("sent");

                                yield return new T[] { item }.Concat(result);
                            }
                        }
                        else
                        {
                            //Console.WriteLine("sent");
                            //Console.WriteLine("^");
                            yield return new T[] { item }.Concat(result);
                        }
                    }
                }
                //Console.WriteLine(i);
                ++i;
                //Console.WriteLine("}}}}}}}}}}}}}}}}}}}}");
            }
        }

    }
}
