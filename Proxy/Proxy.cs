/*
Name: Proxy

Definition:
Provide a surrogate or placeholder for another object to control 
access to it.  

Frequency of use: Medium high

Applicability & Examples:
Virtual Proxies, Remote Proxies
Protection Proxies, Smart References

*/

namespace DesignPattern
{
    #region using
    using System;
    #endregion

    public class Proxy : Subject
    {
        private RealSubject realSubject;

        public override void Request()
        {
            if(this.realSubject == null)
                this.realSubject = new RealSubject();

            this.realSubject.Request();
        }
    }
}