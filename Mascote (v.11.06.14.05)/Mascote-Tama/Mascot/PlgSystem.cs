using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Animation;
using System.Threading;
using System.Reflection;
using IPlugin;

public class Plg
{

    internal List<string> Msg = new List<string>();
    public volatile List<Thread> plugThread;
    public Assembly asm;

    struct pluginParam {

        public int num;
        public string path;
        public string type;

    }

    public Plg(){

        //Запуск плагинов

        System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@"plugin/");// папка с файлами 
        List<string> dirDll = new List<string>();

        foreach (System.IO.FileInfo file in dir.GetFiles("*.dll"))
        {
            dirDll.Add(file.FullName);
        }

        plugThread = new List<Thread>();
        pluginParam plugParamForThreads = new pluginParam();

        for (int i = 0; i < dirDll.Count; i++)
        {

            Msg.Add("");
            plugThread.Add(new Thread(PlugThread));
            plugParamForThreads.num = i;
            plugThread[i].SetApartmentState(ApartmentState.STA);
            plugParamForThreads.path = dirDll[i];
            plugThread[i].Start(plugParamForThreads);

        }

    }

public void PlugThread(object obj) {

		pluginParam param = new pluginParam();
		param = (pluginParam)obj;
		var pluginAssembly = Assembly.LoadFile(param.path);
		var pluginType = pluginAssembly.GetTypes().Where(t => typeof(IPlugin.IPlugin).IsAssignableFrom(t)).Single();
		IPlugin.IPlugin plugin = (IPlugin.IPlugin)pluginType.GetConstructor(new Type[0]).Invoke(null);
        plugin.MainPlug(ref Msg, param.num);

    }

}
