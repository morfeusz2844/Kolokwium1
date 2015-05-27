using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace WordSearcher
{
    /// <summary>
    /// Main class for View Model
    /// TODO: follow guidelines
    /// </summary>
    public class TextViewModel : ITextViewModel
    {
        private readonly IDispatcher _dispatcher;

        private List<string> SlowaKluczowe = new List<string>(); 
        
        public TextViewModel(IDispatcher dispatcher)
        {
            _dispatcher = dispatcher;            
        }
        
        private string _query;
        public string Query
        {
            get
            {
                return _query;
            }
            set
            {
                _query = value;
                NotifyPropertyChanged("Query");
            }
        }

        private string _content;
        public string Content
        {
            get
            {
                return _content;
            }
            set
            {
                value = Globals.LoremIpsum;
                _content = value;
                NotifyPropertyChanged("Content");
            }
        }

        public System.Windows.Input.ICommand SearchCommand
        {
            get { throw new NotImplementedException(); }
        }

        public string SearchResult
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public System.Windows.Input.ICommand SaveSearchesCommand
        {
            get { throw new NotImplementedException(); }
        }

        public ASearcher SelectedMethod
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public IEnumerable<ASearcher> SearchMethods
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(_dispatcher, new PropertyChangedEventArgs(propertyName));
        }

        public void SearchCommandUse()
        {
            if (string.IsNullOrWhiteSpace(Query) && string.IsNullOrWhiteSpace(Content))
            {
                var temp = Content.Split(new Char[] {' '});
                int sum = 0;
                foreach (string s in temp)
                {
                    if (SelectedMethod.VerifyText(s))
                    {
                        sum++;
                    }
                }
                if (sum == 0)
                {
                    SearchResult = Globals.NoSearchResults;
                }
                else
                {
                    SearchResult = Globals.ResultsFound + " " + sum;
                }
            }
        }
    }
}
