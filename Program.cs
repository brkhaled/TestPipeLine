public class Program {
    static void Main(string[] args){

        try{
            string fileName = $"//{args[0]}/Documents/WealthElements/Compare/Cdn_Template_es-MX.pdf";
            bool exists = File.Exists(fileName);
            if(exists){
                Console.WriteLine($"The file \"{fileName}\" exists");
            }
            else{
                Console.WriteLine($"The file \"{fileName}\" DOES NOT exist");
            }
        }
        catch(Exception ex){
            Console.Write("Failed with error: ");
            Console.WriteLine(ex.Message);
        }
    }
}
