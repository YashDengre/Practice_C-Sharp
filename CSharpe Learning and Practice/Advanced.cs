using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace CSharpe_Learning_and_Practice
{
    public class Advanced
    {
        //Regular Expression is pending   - Completed {Means have understand the logic}
        //Operator Overloading is pending - Completed {Understtood the logic}
        //Delegates, Events and Attributes are pending    -  Completed    
    }

    public class IOClass
    {
        //There so many classes to perfom IO operaitons

        //File Stream

        public void ReadWriteFileStream()
        {
            FileStream FS = new FileStream(@"FILEStream.txt", FileMode.OpenOrCreate);
            FS.WriteByte(65);
            FS.WriteByte(65);
            FS.WriteByte(65);
            FS.WriteByte(65);
            FS.WriteByte(65);

            //FS.Close();
            //read
            int i;

            while ((i = FS.ReadByte()) != -1)
            {
                System.Console.WriteLine((char)i);
            }
            var data = FS.CanRead;
            var g = FS.ReadByte();
        }

        public void StreamWriteF()
        {
            FileStream FS = new FileStream(@"StreamWriteReader.txt", FileMode.OpenOrCreate);
            StreamWriter SW = new StreamWriter(FS);
            SW.WriteLine("Hello this is Stream Writer class\n CHeck this out!");
            SW.Close();
            FS.Close();
        }
        public void StreamReaderF()
        {
            FileStream FS = new FileStream(@"StreamWriteReader.txt", FileMode.Open);
            StreamReader SW = new StreamReader(FS);
            string line;
            while ((line = SW.ReadLine()) != null)
            {
                System.Console.WriteLine("" + line);
            }

        }

        public void TextWriterF()
        {
            using (TextWriter tw = File.CreateText(@"TextWrite.txt"))
            {
                tw.WriteLine("This is text writer class\n Have fun!");
            }
        }
        public void TextReaderF()
        {
            using (TextReader tr = File.OpenText(@"TextWrite.txt"))
            {
                string line;
                //while ((line = tr.ReadLine()) != null)
                //{
                //    System.Console.WriteLine(line);
                //}
                line = tr.ReadToEnd();
                System.Console.WriteLine(line);
            }
        }

        public void BinaryWriterF()
        {
            using (BinaryWriter BW = new BinaryWriter(File.Open(@"BinaryWriter.txt", FileMode.OpenOrCreate)))
            {
                BW.Write("Hello Yash Dengre Here and this is Binary Writer Class");
            }
        }
        public void BinaryReaderF()
        {
            using (BinaryReader BR = new BinaryReader(File.Open(@"BinaryWriter.txt", FileMode.Open)))
            {
                System.Console.WriteLine(BR.ReadString());
                //BR.ReadDouble().. etc
            }
        }

        public void StringWriterF()
        {
            string text = "Hello this is String Writer Class";
            StringBuilder SB = new StringBuilder();
            StringWriter SW = new StringWriter(SB);
            SW.WriteLine(text);
            SW.Flush();
            SW.Close();
        }
        public void StringReaderF()
        {
            StringBuilder SB = new StringBuilder();
            StringReader SR = new StringReader(SB.ToString());
            if ((SR.Peek()) != (-1))
            {
                System.Console.WriteLine(SR.ReadToEnd());
            }

        }

        public void FIleInfoCreateF()
        {
            try
            { //use to deal with files
              //create file
                string loc = $"{Environment.CurrentDirectory}\\FileInfo.txt";
                FileInfo FI = new FileInfo(loc);
                FI.Create();
                //we use Stream Writer and  Read to read and write
                FI.Refresh();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception : " + ex.Message);

            }



        }
        public void FIleInfoWriteF()
        {
            try
            {
                string loc = $"{Environment.CurrentDirectory}\\FileInfo.txt";
                FileInfo FI = new FileInfo(loc);
                using (StreamWriter sw = FI.CreateText())
                {
                    sw.WriteLine("Hello thi si FileInfo class and we are writing through Stream Writer class!\n God Bless");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception : " + ex.Message);

            }
        }
        public void FIleInfoReadF()
        {
            try
            {
                string loc = $"{Environment.CurrentDirectory}\\FileInfo.txt";
                FileInfo FI = new FileInfo(loc);
                StreamReader sr = FI.OpenText();
                string data;
                if ((data = sr.ReadToEnd()) != null)
                    Console.WriteLine(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception : " + ex.Message);

            }
        }
        public void FIleInfoDeleteF()
        {
            try
            {
                string loc = $"{Environment.CurrentDirectory}\\FileInfo.txt";
                FileInfo FI = new FileInfo(loc);
                FI.Delete();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception : " + ex.Message);

            }
        }

        public void DirectoryInfoF()
        {
            DirectoryInfo DI = new DirectoryInfo($"{Environment.CurrentDirectory}\\DirectoryInfo");
            if (DI.Exists == false)
            { DI.Create(); }
            else
            {
                DI.Delete();
            }

        }

    }

    [Serializable]
    public class Serialize_DeserializeModel
    {
        public string Name { get; set; }
        public string Message { get; set; }
    }

    public class Serialize_Deserialize
    {

        Serialize_DeserializeModel SDModel = new Serialize_DeserializeModel() { Name = "Yash", Message = "Hello this is Serialized" };
        public void SerializeAndWrite()
        {
            BinaryFormatter BF = new BinaryFormatter();
            FileStream FS = new FileStream(@"Serialize.txt", FileMode.OpenOrCreate);
            BF.Serialize(FS, SDModel);
            FS.Close();

        }
        public void DeserializeAndRead()
        {
            FileStream FS = new FileStream(@"Serialize.txt", FileMode.OpenOrCreate);
            BinaryFormatter BF = new BinaryFormatter();
            var SDModelNew = (Serialize_DeserializeModel)BF.Deserialize(FS);
            Console.WriteLine($"Name: {SDModelNew.Name} and Message: {SDModelNew.Message}");

        }
    }

    public class CustomCollection
    {

        public List<Serialize_DeserializeModel> SerizlizedLIst = new List<Serialize_DeserializeModel>();

        public HashSet<Serialize_DeserializeModel> SerializedHasSet = new HashSet<Serialize_DeserializeModel>();

        public SortedSet<Serialize_DeserializeModel> SerializedSortedSet = new SortedSet<Serialize_DeserializeModel>(new ObjectCompare());

        public Stack<Serialize_DeserializeModel> SerializedStack = new Stack<Serialize_DeserializeModel>();

        public Queue<Serialize_DeserializeModel> SerializedQueue = new Queue<Serialize_DeserializeModel>();

        public LinkedList<Serialize_DeserializeModel> SerializedLinkedList = new LinkedList<Serialize_DeserializeModel>();

        public Dictionary<string, Serialize_DeserializeModel> SerializedDictionary = new Dictionary<string, Serialize_DeserializeModel>();

        public SortedDictionary<string, Serialize_DeserializeModel> SerializedSortedDictionary = new SortedDictionary<string, Serialize_DeserializeModel>();

        public SortedList<string, Serialize_DeserializeModel> SerializedSortedList = new SortedList<string, Serialize_DeserializeModel>();

        public void AddDataToCollections()
        {
            SerizlizedLIst.Add(new Serialize_DeserializeModel() { Name = "Yash1", Message = "List colelction" });
            SerizlizedLIst.Add(new Serialize_DeserializeModel() { Name = "Yash2", Message = "List colelction" });

            SerializedHasSet.Add(new Serialize_DeserializeModel() { Name = "Yash1", Message = "HasSet Collections" });
            SerializedHasSet.Add(new Serialize_DeserializeModel() { Name = "Yash2", Message = "HasSet Collections" });


            SerializedSortedSet.Add(new Serialize_DeserializeModel() { Name = "Yash1", Message = "Sorted Set Collections" });
            SerializedSortedSet.Add(new Serialize_DeserializeModel() { Name = "Yash2", Message = "Sorted Set Collections" });


            SerializedStack.Push(new Serialize_DeserializeModel() { Name = "Yash1", Message = "Stack Collections" });
            SerializedStack.Push(new Serialize_DeserializeModel() { Name = "Yash2", Message = "Stack Collections" });


            SerializedQueue.Enqueue(new Serialize_DeserializeModel() { Name = "Yash1", Message = "Queue Collections" });
            SerializedQueue.Enqueue(new Serialize_DeserializeModel() { Name = "Yash2", Message = "Queue Collections" });


            SerializedLinkedList.AddFirst(new Serialize_DeserializeModel() { Name = "Yash1", Message = "LinkedList Collections" });
            SerializedLinkedList.AddFirst(new Serialize_DeserializeModel() { Name = "Yash2", Message = "LinkedList Collections" });


            SerializedDictionary.Add("FIRST", new Serialize_DeserializeModel() { Name = "Yash1", Message = "Dictionary Collections" });
            SerializedDictionary.Add("Second", new Serialize_DeserializeModel() { Name = "Yash2", Message = "Dictionary Collections" });


            SerializedSortedDictionary.Add("Second", new Serialize_DeserializeModel() { Name = "Yash1", Message = "Soretec Dictionary Collections" });
            SerializedSortedDictionary.Add("First", new Serialize_DeserializeModel() { Name = "Yash2", Message = "Soretec Dictionary Collections" });


            SerializedSortedList.Add("Second", new Serialize_DeserializeModel() { Name = "Yash1", Message = "Sorted List Collections" });
            SerializedSortedList.Add("First", new Serialize_DeserializeModel() { Name = "Yash2", Message = "Sorted List Collections" });

        }

        public void ViewCollecitonsInfo()
        {
            Console.WriteLine("List");
            foreach (var data in SerizlizedLIst)
            {
                Console.WriteLine(data.Name + ":" + data.Message);
            }
            Console.WriteLine("HasSet");
            foreach (var data in SerializedHasSet)
            {
                Console.WriteLine(data.Name + ":" + data.Message);
            }
            Console.WriteLine("Soreted Set");
            foreach (var data in SerializedSortedSet)
            {
                Console.WriteLine(data.Name + ":" + data.Message);
            }
            Serialize_DeserializeModel stack, queue;
            Console.WriteLine("Stack");

            while (SerializedStack.Count > 0)
            {
                stack = SerializedStack.Pop();
                Console.WriteLine(stack.Name + ":" + stack.Message);
            }
            Console.WriteLine("Queue");
            while (SerializedQueue.Count > 0)
            {
                queue = SerializedQueue.Dequeue();
                Console.WriteLine(queue.Name + ":" + queue.Message);
            }
            Console.WriteLine("LinkedList");
            foreach (var data in SerializedLinkedList)
            {
                Console.WriteLine(data.Name + ":" + data.Message);
            }
            Console.WriteLine("Dictionary");
            foreach (var data in SerializedDictionary)
            {
                Console.WriteLine(data.Key + " : " + data.Value.Name + ":" + data.Value.Message);
            }
            Console.WriteLine("Soreted Dictionary");
            foreach (var data in SerializedSortedDictionary)
            {
                Console.WriteLine(data.Key + " : " + data.Value.Name + ":" + data.Value.Message);
            }
            Console.WriteLine("Soreted List");
            foreach (var data in SerializedSortedList)
            {
                Console.WriteLine(data.Key + " : " + data.Value.Name + ":" + data.Value.Message);
            }
        }

    }

    public class ObjectCompare : IComparer<Serialize_DeserializeModel>
    {
        public int Compare(Serialize_DeserializeModel x, Serialize_DeserializeModel y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }

}


