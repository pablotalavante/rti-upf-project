using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Logger : MonoBehaviour
{
	public string position_file_pre; // file will be named 'position_file_pre_<name>_<age>_<gender>_<group>.csv'
	public string heading_file_pre; // file will be named 'heading_file_pre_<name>_<age>_<gender>_<group>.csv'

	public string log_file;
    public float log_every; // how long to wait between logging

    public GameObject participant;
	public State state;

	private Writer position_writer;
	private Writer heading_writer;

	class Writer
    {
		private StreamWriter stream_writer;

		public void Write(string line)
        {
			this.stream_writer.WriteLine(line);
        }

		public void Close()
        {
			this.stream_writer.Close();
        }

		public Writer(string log_file)
        {
			this.stream_writer = new StreamWriter(Application.persistentDataPath + log_file);
        }
    }

	string ComposeFileName(string file_pre)
    {
        return file_pre + "_" + state.first_name + "_" + state.age + "_" + state.gender + "_" + state.group + ".csv";
    }

    // Start is called before the first frame update
    void Start()
    {
		position_writer = new Writer(ComposeFileName(position_file_pre));
		heading_writer = new Writer(ComposeFileName(heading_file_pre));

		InvokeRepeating("LogPlayerPosition", 0f, log_every);
		InvokeRepeating("LogPlayerHeading", 0f, log_every);
    }

	string Vector3ToCSV(Vector3 vector)
    {
		return vector.x.ToString() + "," + vector.y.ToString() + "," + vector.z.ToString();
    }

	void LogPlayerHeading()
    {
		string line = Time.time.ToString() + "," + state.progression.ToString() + ",";
		line += Vector3ToCSV(participant.transform.Find("Camera").transform.forward);
		heading_writer.Write(line);
    }


	void LogPlayerPosition()
    {
		string line = Time.time.ToString() + "," + state.progression.ToString() + ",";
		line += Vector3ToCSV(participant.transform.position);
		position_writer.Write(line);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void OnDestroy(){
		position_writer.Close();
		heading_writer.Close();
		
	}

}
