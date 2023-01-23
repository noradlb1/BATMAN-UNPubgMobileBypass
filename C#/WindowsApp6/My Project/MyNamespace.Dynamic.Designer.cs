﻿using System;
using System.ComponentModel;
using System.Diagnostics;

namespace WindowsApp6.My
{
    internal static partial class MyProject
    {
        internal partial class MyForms
        {

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Form1 m_Form1;

            public Form1 Form1
            {
                [DebuggerHidden]
                get
                {
                    m_Form1 = Create__Instance__(m_Form1);
                    return m_Form1;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Form1))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Form1);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Form2 m_Form2;

            public Form2 Form2
            {
                [DebuggerHidden]
                get
                {
                    m_Form2 = Create__Instance__(m_Form2);
                    return m_Form2;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Form2))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Form2);
                }
            }

        }


    }
}