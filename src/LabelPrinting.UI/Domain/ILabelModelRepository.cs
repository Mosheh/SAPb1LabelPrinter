using LabelPrinting.UI.Domain.PrintServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabelPrinting.UI.Domain
{
    public interface ILabelModelRepository
    {
        void Add(LabelModel labelModel);
        void Update(LabelModel labelModel);
        void Remove(int key);

        IEnumerable<LabelModel> GetAll();
    }
}
