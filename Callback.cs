/*******************************************************************************/
/*!
\file   Callback.cs
\author Nathan Negreiro
\par    All content © Nathan Negreiro, all rights reserved.

\brief
  Provides templated types to use with messaging
  
*/
/*******************************************************************************/
public delegate void Callback();
public delegate void Callback<T>(T arg1);
public delegate void Callback<T, U>(T arg1, U arg2);
public delegate void Callback<T, U, V>(T arg1, U arg2, V arg3);