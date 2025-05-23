/*********************************************************************

 ADOBE SYSTEMS INCORPORATED
 Copyright (C) 2000-2006 Adobe Systems Incorporated
 All rights reserved.

 NOTICE: Adobe permits you to use, modify, and distribute this file
 in accordance with the terms of the Adobe license agreement
 accompanying it. If you have received this file from a source other
 than Adobe, then your use, modification, or distribution of it
 requires the prior written permission of Adobe.

 ---------------------------------------------------------------------

 InvokeMakeAccessibleCmdSnip.cpp

*********************************************************************/

#include "SnippetRunner.h"
#include "SnippetRunnerUtils.h"

// directly pull in AVCmdDefs.h which defines some command specific enums and the textual identifier for the command.
#include "AVCmdDefs.h"

/** Invokes the MakeAccessible comments command. This command has no inputs and takes no parameter. 
	We indicate the command is to be executed with no UI.
	@requires open pdf
	@see AVCommandNew
	@see ASCabNew
	@see ASCabPutInt
	@see AVCommandSetConfig
	@see ASCabDestroy
	@see AVCommandDestroy
	@see AVCommandExecute
*/
void InvokeMakeAccessibleCmdSnip()
{
	ASAtom cmdName;
	AVCommand volatile cmd = NULL;
	AVCommandStatus cmdStatus;
	volatile ASCab config = NULL;
	ASBool errorState = false;

	// Ensure there's an open doc...
	if (AVAppGetActiveDoc() == NULL) {
		AVAlertNote( "This snippet requires an open document." );
		return;
	}

	DURING
		// Create an instance of the command.
		cmdName = ASAtomFromString(kAVCommandMakeAccessible);
		cmd = AVCommandNew(cmdName);
		if (cmd==NULL){
			// if we cannot get the command, just alert. 
			AVAlertNote("Cannot obtain the command");
			errorState = true;
			
		}
		if (errorState == false){
			// We wish to invoke this command without any user interaction. See AVExpT.h for other UI policies
			config = ASCabNew();
			ASCabPutInt(config, "UIPolicy", kAVCommandUISilent);

			// Set command configuration 
			cmdStatus = AVCommandSetConfig(cmd, config);

			// this command has no inputs.
			
			// this command takes no parameters.
		}
			
	HANDLER
		cmdStatus = kAVCommandInError;
	END_HANDLER

	if (ASBoolToBool(errorState) == true){
		return;
	}
	
	if (config!=NULL){
		ASCabDestroy(config);
	}
		
	// we have set up the command, make sure there isn't a latent error
	// We're in silent mode, so we won't throw an alert dialog.
	if (kAVCommandInError == cmdStatus) {
		AVCommandDestroy(cmd);
		return;
	}

	// we should be good to go at this point, execute the command.
	cmdStatus = AVCommandExecute(cmd);

	// Release the resources associated with the command.
	AVCommandDestroy(cmd);
}

SNIPRUN_REGISTER(InvokeMakeAccessibleCmdSnip, "AV Layer:Commands:Invoke MakeAccessible Cmd", "Invokes the MakeAccessible command.")


