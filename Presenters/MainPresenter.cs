using supermarket.Models;
using supermarket.Presenters;
using supermarket.Repositories;
using supermarket.Views;

private void showPayModeView(object? sender, EventArgs e)
{
    IPayModeView view = PayModeView.GetInstance();
    IPayModeView view = PayModeView.GetInstance((MainView)mainView);
    IPayModeRepository repository = new PayModeRepository(sqlConnectionString);
    new PayModePresenter(view, repository);
}
