using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proxy
{
    public class ExpensiveOperationProxy : IExpensiveOperation
    {
        private ExpensiveOperation _expensiveOperation;
        private Dictionary<int, int> _cache;

        public ExpensiveOperationProxy() { 
            _expensiveOperation = new ExpensiveOperation();
            _cache = new Dictionary<int, int>();
        }
        public int PerformOperation(int input) {

            if (_cache.ContainsKey(input)) {
                // if the result is cached, returns the result from cache // if the result is cached, returns the result from cache
                return _cache[input];
            }else {
                //if the result is not in the cache, performs the actual operation
                int result = _expensiveOperation.PerformOperation(input);
                _cache.Add(input, result);
                return result;
            }
        }
    }
}
