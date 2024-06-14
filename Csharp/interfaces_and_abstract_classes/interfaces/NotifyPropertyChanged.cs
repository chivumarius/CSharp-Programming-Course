using System.ComponentModel;

namespace CSharp.interfaces_and_abstract_classes.interfaces;


// ▬▬ "INotifyPropertyChanged" Interface
//      → will "Notify Subscribers" 
//      → when a "Property" is "Changed" ▬
public class NotifyPropertyChanged : INotifyPropertyChanged
{
    // ▼ Private "Field"
    //      → to "Store" the "Value"
    //      → of the "Name" Property ▼
    private string _name; 

    
    // ▼ Implementing the "PropertyChanged" Event
    //      → of the "INotifyPropertyChanged" Interface ▼
    public event PropertyChangedEventHandler PropertyChanged;

    
    // ▼ "Property"
    //      → to "Access" the "Name" Field ▼
    public string Name
    {
        get
        {
            // ▼ "Return" the "Value" of the "Private Field" ▼
            return _name; 
        }
        set
        {
            // ▼ "Set" the "Value" of the "Private Field" ▼
            _name = value; 

            
            // ▼ "Notify Subscribers"
            //      → that the "Property"
            //      → has "Changed" ▼
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
        }
    }
}