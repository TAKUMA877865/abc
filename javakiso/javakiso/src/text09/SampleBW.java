package text09;

import java.io.BufferedWriter;
import java.io.FileWriter;
import java.io.IOException;

public class SampleBW {

	public static void main(String[] args) throws IOException{
		
		
//		FileWriter fw = new FileWriter("data.txt");
//		BufferedWriter bw = new BufferedWriter(fw);
		
		BufferedWriter bw = new BufferedWriter( new FileWriter("data.txt"));
		
		
		bw.write("Hello World!!\n");
		bw.newLine();/*改行するメソッド*/
		bw.close();

	}

}
