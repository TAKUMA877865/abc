package text09;

import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;

public class SampleBR {

	public static void main(String[] args) throws IOException {
//		FileReader fr = new FileReader("data.txt");
//		BufferedReader br = new BufferedReader(fr);
		
		BufferedReader br = new BufferedReader(new FileReader("data.txt"));
		String line = null;
		while((line = br.readLine()) != null) {
			System.out.println(line);
			
		}
		br.close();

	}

}
