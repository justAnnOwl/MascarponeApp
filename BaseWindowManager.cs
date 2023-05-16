using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Kursach_6_sem_UIP
{
    public class BaseWindowManager
    {
        private static BaseWindowManager _instance;

        private readonly Type[] FormsTypes = new Type[] {
            typeof(HelloPage),
            typeof( Registration), 
            typeof( Enter), 
            typeof(UserMenu), 
            typeof(PersonalRegistration),
            typeof(AdminCatalogue), 
            typeof(ChangePassword),
            typeof(Catalogue)
        };
        
        protected readonly Dictionary<Type, Form> Windows = new();

        public static void OnStart()
        {
            _instance = new BaseWindowManager();

            LoadAll();
        }
        
        private void LoadAllInternal()
        {
            foreach(Type byType in FormsTypes) {
                var instance = Convert.ChangeType(Activator.CreateInstance(byType), byType);
                Windows.Add(byType, (Form)instance);
               
            }
        }

        protected void ShowInternal<TWindow>() where TWindow : Form
        {
            var targetWindow = Windows[typeof(TWindow)];
            
            
                targetWindow.Show();

           
        }

        protected virtual void HideInternal<TWindow>() where TWindow : Form
        {
            var targetWindow = Windows[typeof(TWindow)];

           
                targetWindow.Hide();

           
        }

        protected virtual void CloseAllInternal()
        {
            foreach (var targetWindow in Windows)
            {
               
                    targetWindow.Value.Close();
                
            }
        }

        public static void LoadAll() => _instance.LoadAllInternal();
        
        public static void Show<TWindow>() where TWindow: Form => _instance.ShowInternal<TWindow>();
        
        public static void Hide<TWindow>() where TWindow: Form => _instance.HideInternal<TWindow>();
        
        public static void CloseAll() => _instance.CloseAllInternal();
    }
}