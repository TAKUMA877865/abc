package text09;

import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;

public class SampleCSV02  {

	public static void main(String[] args) throws IOException{
		// TODO 自動生成されたメソッド・スタブ
		String fname = "write.csv";
		BufferedReader br = new BufferedReader(new FileReader(fname));
		String line = "";
		while((line = br.readLine()) != null) {
			String[] st = line.split(",");
			System.out.printf("%s %s %s\n",st[0],st[1],st[2]);
		}
		br.close();
	}
}
		

