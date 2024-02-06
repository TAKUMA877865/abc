package text09;

import java.io.BufferedWriter;
import java.io.File;
import java.io.FileWriter;
import java.io.IOException;

public class SampleCSVOUT01 {

	public static void main(String[] args) throws IOException{
		File csv = new File("write.csv");
		BufferedWriter bw = new BufferedWriter(new FileWriter(csv,true));
		bw.write("田中佳子" + "," + "1946" + "," + "1992");
		bw.newLine();
		bw.close();
		

	}

}
