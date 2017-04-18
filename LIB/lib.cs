using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace tcp
{
	public class LIB
	{
		private LIB ()
		{
		}

		/// <summary>
		/// Extracts the name of the file.
		/// </summary>
		/// <returns>
		/// The filename only.
		/// </returns>
		/// <param name='fileName'>
		/// Filename with path.
		/// </param>
		public static String extractFileName(String fileName)
    	{
    		return (fileName.LastIndexOf('/')==0 ? fileName : fileName.Substring(fileName.LastIndexOf('/')+1));
    	}

		/// <summary>
		/// Reads the text from the server/client
		/// </summary>
		/// <returns>
		/// The text.
		/// </returns>
		/// <param name='io'>
		/// Network stream for reading from the server/client.
		/// </param>
		public static String readTextTCP (NetworkStream io)
		{
	        String line = "";
	        char ch;
	        
	        while((ch = (char)io.ReadByte()) != 0)
	        	line += ch;

	        return line;
		}

		/// <summary>
		/// Check_s the file_ exists.
		/// </summary>
		/// <returns>
		/// The filesize.
		/// </returns>
		/// <param name='fileName'>
		/// The filename.
		/// </param>
		public static long check_File_Exists (String fileName)
		{
			if (File.Exists (fileName))
				return (new FileInfo(fileName)).Length;

			return 0;
		}
	}
}

