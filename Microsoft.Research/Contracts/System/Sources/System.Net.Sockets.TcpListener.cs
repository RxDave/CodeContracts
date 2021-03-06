// CodeContracts
// 
// Copyright (c) Microsoft Corporation
// 
// All rights reserved. 
// 
// MIT License
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

// File System.Net.Sockets.TcpListener.cs
// Automatically generated contract file.
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Diagnostics.Contracts;
using System;

// Disable the "this variable is not used" warning as every field would imply it.
#pragma warning disable 0414
// Disable the "this variable is never assigned to".
#pragma warning disable 0067
// Disable the "this event is never assigned to".
#pragma warning disable 0649
// Disable the "this variable is never used".
#pragma warning disable 0169
// Disable the "new keyword not required" warning.
#pragma warning disable 0109
// Disable the "extern without DllImport" warning.
#pragma warning disable 0626
// Disable the "could hide other member" warning, can happen on certain properties.
#pragma warning disable 0108


namespace System.Net.Sockets
{
  public partial class TcpListener
  {
    #region Methods and constructors
    public Socket AcceptSocket()
    {
      Contract.Ensures(Contract.Result<System.Net.Sockets.Socket>() != null);

      return default(Socket);
    }

    public TcpClient AcceptTcpClient()
    {
      Contract.Ensures(Contract.Result<System.Net.Sockets.TcpClient>() != null);

      return default(TcpClient);
    }

    public void AllowNatTraversal(bool allowed)
    {
    }

    public IAsyncResult BeginAcceptSocket(AsyncCallback callback, Object state)
    {
      Contract.Ensures(Contract.Result<System.IAsyncResult>() != null);

      return default(IAsyncResult);
    }

    public IAsyncResult BeginAcceptTcpClient(AsyncCallback callback, Object state)
    {
      Contract.Ensures(Contract.Result<System.IAsyncResult>() != null);

      return default(IAsyncResult);
    }

    public Socket EndAcceptSocket(IAsyncResult asyncResult)
    {
      return default(Socket);
    }

    public TcpClient EndAcceptTcpClient(IAsyncResult asyncResult)
    {
      Contract.Ensures(Contract.Result<System.Net.Sockets.TcpClient>() != null);

      return default(TcpClient);
    }

    public bool Pending()
    {
      return default(bool);
    }

    public void Start()
    {
    }

    public void Start(int backlog)
    {
    }

    public void Stop()
    {
    }

    public TcpListener(System.Net.IPEndPoint localEP)
    {
    }

    public TcpListener(int port)
    {
    }

    public TcpListener(System.Net.IPAddress localaddr, int port)
    {
    }
    #endregion

    #region Properties and indexers
    protected bool Active
    {
      get
      {
        return default(bool);
      }
    }

    public bool ExclusiveAddressUse
    {
      get
      {
        return default(bool);
      }
      set
      {
      }
    }

    public System.Net.EndPoint LocalEndpoint
    {
      get
      {
        return default(System.Net.EndPoint);
      }
    }

    public Socket Server
    {
      get
      {
        return default(Socket);
      }
    }
    #endregion
  }
}
