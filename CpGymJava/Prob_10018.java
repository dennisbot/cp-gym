import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;

public class Prob_10018 {

    public static void main(String[] args) throws FileNotFoundException {
        String local = System.getenv("DENNISBOT");
        Scanner sc = local != null ? new Scanner(new File("src/Prob_10018.in")) : new Scanner(System.in);
        int N = Integer.parseInt(sc.nextLine());
        while (N-- > 0)
        {
            int iteration = 0;
            long number = Long.parseLong(sc.nextLine());
            do
            {
                String reverse = "";
                String numAsString = String.valueOf(number);
                int numLen = numAsString.length();
                for (int i = 0; i < numLen; i++)
                {
                    reverse += numAsString.charAt(numLen - i - 1);
                }
                number = number + Integer.parseInt(reverse);
                iteration++;
            } while (!IsPalindrome(number));

            System.out.println(String.format("%1$s %2$s", iteration, number));
        }
    }
    private static boolean IsPalindrome(long number)
    {
        String numAsString = String.valueOf(number);
        int len = numAsString.length();
        for (int i = 0; i < len / 2; i++)
        {
            if (numAsString.charAt(i) != numAsString.charAt(len - i - 1))
            {
                return false;
            }
        }

        return true;
    }
}
