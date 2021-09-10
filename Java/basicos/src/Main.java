import java.util.Scanner;
import java.util.Locale;

public class Main{
	public static void main(String[] args) {

		Locale.setDefault(new Locale("en", "US"));

		Scanner sc = new Scanner(System.in);
		
		String[] cpf = new String[4]; 

                
		cpf = sc.nextLine().split("(\\.|-)");


			System.out.println(String.join("\n", cpf));

		sc.close();
	}
}