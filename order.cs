string[] words = { "the", "quick", "brown", "fox", "jumps" };  

  

IEnumerable<string> query = from word in words  

                            orderby word.Length  

                            select word;  

  

foreach (string str in query)  

    Console.WriteLine(str);  

  

/* This code produces the following output:  

  

    the  

    fox  

    quick  

    brown  

    jumps  

*/
