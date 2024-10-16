namespace TabWindow.Models
{
    class GlobalModel
    {
        readonly List<TabModel> _tabModels = new List<TabModel>();

        public TabModel AddModel()
        {
            _tabModels.Add(new TabModel(_tabModels.Count + 1));

            return _tabModels[^1];
        }
    }
}
