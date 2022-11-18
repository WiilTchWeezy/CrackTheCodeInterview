using System;
using System.Collections.Generic;
using System.Text;

namespace CrackTheCodeInterview.OO
{
    public abstract class Entry
    {
        protected DateTime createdDate;
        protected DateTime lastUpdated;
        protected DateTime lastAccess;
        protected string Name;

        public Entry(string name)
        {
            this.Name = name;
            createdDate = DateTime.UtcNow;
            lastUpdated = DateTime.UtcNow;
            lastAccess = DateTime.UtcNow;
        }

        public string GetName()
        {
            return Name;
        }
    }

    public class Directory : Entry
    {
        public List<File> Files = new List<File>();
        public List<Directory> Directories = new List<Directory>();

        private Directory _parent;
        public Directory(string name) : base(name)
        {

        }
    }

    public class File : Entry
    {
        public Directory Directory { get; set; }
        public int Size { get; set; }
        public File(string name, Directory directory) : base(name)
        {
            Directory = directory;
        }
    }
}
