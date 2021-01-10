using System.Collections.Generic;

namespace MfpcProject.Administrative
{
    public class Deadlock
    {
        public int Id { get; set; }
        public string LockType { get; set; }
        public string LockTable { get; set; }
        public int LockObject { get; set; }
        public int TransactionHasLock { get; set; }
        public List<int> TransactionWaitsLock { get; set; }
    }
}
