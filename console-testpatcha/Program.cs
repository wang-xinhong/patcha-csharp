using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using SingleColorFactory = org.patchca.color.SingleColorFactory;
using org.patchca.filter.predefined;
using ConfigurableCaptchaService = org.patchca.service.ConfigurableCaptchaService;
using EncoderHelper = org.patchca.utils.encoder.EncoderHelper;
using java.io;
using java.awt;
using org.patchca.color;
using patchaLib.extender;

namespace console_testpatcha
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfigurableCaptchaService cs = new ConfigurableCaptchaService();
            //cs.ColorFactory = new RainbowColorFactory();
            cs.ColorFactory = new SingleColorFactory(new Color(25, 60, 170));
            cs.FilterFactory = new CurvesWithDiffuseRippleFilterFactory(cs.ColorFactory);
            //cs.FilterFactory = new CurvesRippleFilterFactory(cs.ColorFactory);

            FileOutputStream fos = new FileOutputStream("patcha_demo.png");

            System.Console.WriteLine(DateTime.Now);

            for(int i=0; i<100; i++)
            {
                EncoderHelper.getChallangeAndWriteImage(cs, "png", fos);
            }

            System.Console.WriteLine(DateTime.Now);

            fos.close();

        }
    }


}
