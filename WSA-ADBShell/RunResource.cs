﻿using AdbShell;
using AdbShell.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SimpleUI.Interface.AppInterfaces;
using SimpleUI.Interface.AppInterfaces.Services;
using SimpleUI.Services;
using SimpleUI.Utils;
using WSA_ADBShell.ViewModels;
using WSA_ADBShell.Views;

namespace WSA_ADBShell;

public static class RunResource
{
    public static IHostBuilder RegiserViews(this IHostBuilder hostBuilder)
    {
        hostBuilder.ConfigureServices((content, service) =>
        {
            service.AddSingleton<MainWindow>();
            service.AddSingleton<APKManagerPage>();
        });
        return hostBuilder; 
    }


    public static IHostBuilder RegiserViewModels(this IHostBuilder hostBuilder)
    {
        hostBuilder.ConfigureServices((content, service) =>
        {
            service.AddSingleton<MainViewModel>();
            service.AddSingleton<APKManagerViewModel>();
        });
        return hostBuilder;
    }

    public static IHostBuilder RegiserService(this IHostBuilder hostBuilder)
    {
        hostBuilder.ConfigureServices((content, service) =>
        {
            //对话框
            service.AddSingleton<IShowDialogService,ShowDialogService>();

            //小弹窗服务
            service.AddSingleton<IToastLitterMessage,ToastLitterMessage>();

            //进程服务
            service.AddSingleton<ProcessManager>();

            //ADB管理器
            service.AddSingleton<IAdbManager,AdbManager>();
        });
        return hostBuilder;
    }

    public static IHostBuilder RegiserExtend(this IHostBuilder hostBuilder)
    {
        hostBuilder.ConfigureServices((content, service) =>
        {
            service.AddSingleton<IAppNavigationViewService, AppNavigationViewService>();
        });
        return hostBuilder;
    }
}

