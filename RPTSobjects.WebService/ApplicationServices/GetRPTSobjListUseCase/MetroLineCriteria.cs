using RPTSobj.DomainObjects;
using RPTSobj.DomainObjects.Ports;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace RPTSobj.ApplicationServices.GetRPTSobjListUseCase
{
    public class MetroLineCriteria : ICriteria<DomainObjects.RPTSobj>
    {
        public string MetroLine { get; }      /*save filtration criteria*/

        public MetroLineCriteria(string metroLine) /*get criteria and save as class member*/
            => MetroLine = metroLine;

        public Expression<Func<DomainObjects.RPTSobj, bool>> Filter
            => (rpts => rpts.MetroLine == MetroLine); /*Filter*/
    }
}
