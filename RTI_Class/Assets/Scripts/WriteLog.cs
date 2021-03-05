using UnityEngine;
using System.Collections;
using System.IO;
using System.Globalization;
using System;

public class WriteLog {
	
	System.IO.StreamWriter logFile;
	System.IO.StreamWriter logFile1;

	string msg;
	public bool logToFile = true;
	bool logClosed;
    string fname = "/experiment_logs/"; 
	
	/*public writeLog (bool isTrajectory) {

		if(!Directory.Exists(Application.dataPath + fname)){

			Directory.CreateDirectory(Application.dataPath + fname);
		}


		if (!isTrajectory) {
			string path = Application.dataPath + fname + "_" +DateTime.Now.ToString ("yyyMMddHHmm") + "-log.txt";		
			logFile = new System.IO.StreamWriter(path, true);
			logFile.WriteLine("#Starting log sesion" );
		} else {
            string path = Application.dataPath + fname + "_" + DateTime.Now.ToString("yyyMMddHHmm") + "-trajectory.txt";		
			logFile1 = new System.IO.StreamWriter(path, true);
			logFile1.WriteLine("#Starting log sesion" );
		}
	}*/
	
	public void LogMessage(string message){
		if(logFile!=null){
			string logMsg = message;
			logFile.WriteLine(logMsg);
		}
		if(logFile1!=null){
			string logMsg = message;
			logFile1.WriteLine(logMsg);
		}
	}
	
	public void Close(){
		
		if(logFile != null){
			logFile.WriteLine("#Ending log sesion");
			logFile.Close();
			logFile = null;
		}
		if(logFile1 != null){
			logFile1.WriteLine("#Ending log sesion");
			logFile1.Close();
			logFile1 = null;
		}
	}
	
	public void OnDestroy(){
		Close();
		
	}
}
