using System;

namespace nullable_repro
{
    public class Recursive
    {
        public void Method(Action<Recursive> next)
        {

        }

        public void Initial(Recursive recurse)
        {
            recurse.Method(((recurse2) =>
            {

                recurse2.Method(((recurse3) =>
                {

                    recurse3.Method(((recurse4) =>
                    {

                        recurse4.Method(((recurse5) =>
                        {

                            recurse5.Method(((recurse6) =>
                            {

                                recurse6.Method(((recurse7) =>
                                {

                                    recurse7.Method(((recurse8) =>
                                    {

                                        recurse8.Method(((recurse9) =>
                                        {

                                            recurse9.Method(((recurse10) =>
                                            {

                                                recurse10.Method(((recurse11) =>
                                                {

                                                    recurse11.Method(((recurse12) =>
                                                    {

                                                        recurse12.Method(((recurse13) =>
                                                        {

                                                            recurse13.Method(((recurse14) =>
                                                            {

                                                                recurse14.Method(((recurse15) =>
                                                                {

                                                                    recurse15.Method(((recurse16) =>
                                                                    {

                                                                        recurse16.Method(((recurse17) =>
                                                                        {

                                                                            recurse17.Method(((recurse18) =>
                                                                            {

                                                                                recurse18.Method(((recurse19) =>
                                                                                {

                                                                                    recurse19.Method(((recurse20) =>
                                                                                    {

                                                                                        recurse20.Method(((recurse21) =>
                                                                                        {


                                                                                        }
                                                                                        ));

                                                                                    }
                                                                                    ));

                                                                                }
                                                                                ));

                                                                            }
                                                                            ));

                                                                        }
                                                                        ));

                                                                    }
                                                                    ));

                                                                }
                                                                ));

                                                            }
                                                            ));

                                                        }
                                                        ));

                                                    }
                                                    ));

                                                }
                                                ));

                                            }
                                            ));

                                        }
                                        ));

                                    }
                                    ));

                                }
                                ));

                            }
                            ));

                        }
                        ));

                    }
                    ));

                }
                ));

            }
            ));
        }
    }
}
