﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using DevelopmentInProgress.DipState;

namespace DevelopmentInProgress.ExampleModule.Model
{
    public class Customer : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Name { get; set; }
        public string SortCode { get; set; }
        public string AccountNumber { get; set; }
        public string Address { get; set; }

        public List<State> RemediationWorkflow { get; set; }

        public List<State> RedressWorkflow
        {
            get
            {
                return RemediationWorkflow.Where(s => s.Type == StateType.Standard
                                                      && !s.Name.Equals("Communication")
                                                      && !s.Parent.Name.Equals("Communication")).ToList();
            }
        }

        public List<State> CommunicationWorkflow
        {
            get
            {
                return RemediationWorkflow.Where(s => s.Type == StateType.Standard
                                                      && s.Parent.Name.Equals("Communication")).ToList();
            }
        }

        public void Refresh()
        {
            OnPropertyChanged(String.Empty);
        }

        public void OnPropertyChanged(string propertyName)
        {
            var propertyChangedHandler = PropertyChanged;
            if (propertyChangedHandler != null)
            {
                propertyChangedHandler(this, new PropertyChangedEventArgs(propertyName));
                RemediationWorkflow.OfType<EntityBase>().ToList().ForEach(s => ((EntityBase) s).OnPropertyChanged("Status"));
            }
        }
    }
}