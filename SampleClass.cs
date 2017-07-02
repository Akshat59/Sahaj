using System;
using m1.BPC;

public class SampleClass
{
	public SampleClass()
	{
    }

    #region Constructor

    #endregion

    #region Objects

    private genBPC _genBPC;

    public genBPC GenBPC
    {
        get { if (_genBPC == null) { _genBPC = new genBPC(); } return _genBPC; }

    }

    #endregion 

    #region Properties

    #endregion 

    #region Controls

    #endregion

    #region PrivateMethods

    #endregion
}
