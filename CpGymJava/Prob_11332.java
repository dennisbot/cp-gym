import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;

public class Prob_11332 {

    public static void main(String[] args) throws FileNotFoundException {
        String local = System.getenv("DENNISBOT");
        Scanner sc = local != null ? new Scanner(new File("src/Prob_11332.in")) : new Scanner(System.in);
        int n = Integer.parseInt(sc.nextLine());
        do
        {
            while (n >= 10) {
                n = Function(n);
            }
            System.out.println(String.format("%d", n));
            n = Integer.parseInt(sc.nextLine());
        } while (n != 0);
    }
    private static int Function(int number)
    {
        int newN = 0;
        while (number > 0) {
            newN += number % 10;
            number /= 10;
        }
        return newN;
    }
}
