using System;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Rbmk.Radish.Model.ExplorerPad.ConnectionExplorer;
using Rbmk.Radish.Model.ExplorerPad.ConnectionExplorer.Nodes;
using Rbmk.Utils.Reactive;
using ReactiveUI;

namespace Rbmk.Radish.Views.ExplorerPad.ConnectionExplorer.Nodes
{
    public class ConnectionNodeControl : BaseControl<ConnectionNodeModel>
    {
        public ConnectionNodeControl()
            : base(false)
        {
            AvaloniaXamlLoader.Load(this);

            this.WhenActivated(disposables =>
            {
                Observable.FromEventPattern<RoutedEventArgs>(
                        h => DoubleTapped += h, h => DoubleTapped -= h)
                    .Throttle(TimeSpan.FromMilliseconds(200))
                    .ObserveOn(RxApp.MainThreadScheduler)
                    .SubscribeWithLog(_ =>
                    {
                        ViewModel.ReconnectCommand.Execute()
                            .SubscribeWithLog()
                            .DisposeWith(disposables);
                    });
            });
        }
    }
}