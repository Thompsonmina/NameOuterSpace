﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Reactive.Linq;
using ReactiveUI;
using SearchEngine;


namespace SearchEngineClient.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        ViewModelBase content;

        public ViewModelBase Content
        {
            get => content;
            private set => this.RaiseAndSetIfChanged(ref content, value);
        }

        public MainWindowViewModel(Querier querier)
        {
            this.content = new SearchViewModel(querier);
        }
    }
}