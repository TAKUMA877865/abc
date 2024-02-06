package text09;
import java.io.FileWriter;
import java.io.IOException;
public class SampleBW01 {

	public static void main(String[] args) throws IOException{
		// TODO 自動生成されたメソッド・スタブ
		FileWriter fw = new FileWriter("data.txt");
		fw.write("あHello World!!\n");
		fw.close();

	}

}
