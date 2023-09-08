using System.Collections.Generic;
namespace Vehicle_dl;
class DetailPartsRepository : IDetailPartsRepository
{
    private List<DetailParts> _listOfDetail;
    public DetailPartsRepository()
    {
        _listOfDetail= new List<DetailParts>();
    }
    public DetailParts this[string name]
    {
        get => _listOfDetail.Find(o => o.Name == name);   
        set 
        {
            DetailParts detailParts = _listOfDetail.Find(o => o.Name == name);
            detailParts.Name = value.Name;
            detailParts.Weight = value.Weight;
            detailParts.Description = value.Description;
        }
    }
    public bool Create(DetailParts detailParts)
    {
        throw new NotImplementedException();
    }

}