using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SocialNetworkingSiteLibrary;

/// <summary>
/// Summary description for ClassChatOperation
/// </summary>
public class ClassChatOperation
{
	public ClassChatOperation()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public bool iniitializeChatSystem(ClassChatDetails chat)
    {
        bool flag = false;
        return flag;

    }

    public bool sendSms(ClassChatDetails chat)
    {
        bool flag = true;
        return flag;
    }

    public List<ClassChatDetails> getAllMessage(ClassUserId sender, ClassUserId reciever)
    {
        return null;
    }
}
