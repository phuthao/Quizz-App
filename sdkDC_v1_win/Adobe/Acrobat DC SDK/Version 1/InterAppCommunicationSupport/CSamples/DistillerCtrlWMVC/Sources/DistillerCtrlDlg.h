/*********************************************************************

 ADOBE SYSTEMS INCORPORATED
 Copyright (C) 1994-2006 Adobe Systems Incorporated
 All rights reserved.

 NOTICE: Adobe permits you to use, modify, and distribute this file
 in accordance with the terms of the Adobe license agreement
 accompanying it. If you have received this file from a source other
 than Adobe, then your use, modification, or distribution of it
 requires the prior written permission of Adobe.

 ---------------------------------------------------------------------

 DistillerCtrlDlg.h : Header file.

*********************************************************************/

#if !defined(AFX_DISTILLERCTRLDLG_H__BDD00381_EF41_11D4_B82B_00C04F311E65__INCLUDED_)
#define AFX_DISTILLERCTRLDLG_H__BDD00381_EF41_11D4_B82B_00C04F311E65__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

/////////////////////////////////////////////////////////////////////////////
// CDistillerCtrlDlg dialog

class CDistillerCtrlDlg : public CDialog
{
// Construction
public:
	CDistillerCtrlDlg(CWnd* pParent = NULL);	// standard constructor

// Dialog Data
	//{{AFX_DATA(CDistillerCtrlDlg)
	enum { IDD = IDD_DISTILLERCTRL_DIALOG };
	CString	m_inputFile;
	//}}AFX_DATA

	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CDistillerCtrlDlg)
	public:
	virtual BOOL DestroyWindow();
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:
	HANDLE m_hProcess;
	CWnd *m_pDistillerWnd;
	HICON m_hIcon;
	WORD m_enqueueOption;

	// Generated message map functions
	//{{AFX_MSG(CDistillerCtrlDlg)
	virtual BOOL OnInitDialog();
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	afx_msg void OnSelectInput();
	afx_msg void OnProcessFile();
	afx_msg void OnNoInteraction();
	afx_msg void OnSourceLocation();
	afx_msg void OnMostRecentLocation();
	afx_msg BOOL OnCopyData(CWnd* pWnd, COPYDATASTRUCT* pCopyDataStruct);
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_DISTILLERCTRLDLG_H__BDD00381_EF41_11D4_B82B_00C04F311E65__INCLUDED_)
