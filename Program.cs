﻿TLogger.Instance.Active();

ControllerManager.Instance.Active();

RegisterController();

TLogger.LogInfo("Start TEngine Server");

RunTcpServer().Wait();

static async Task RunTcpServer()
{
    await TcpServer.Start(54809);
}

static void RegisterController()
{
    ControllerManager.Instance.RegisterController(SocketGameProtocol.RequestCode.User, new UserController());
}