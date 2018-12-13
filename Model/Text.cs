using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
namespace Model
{
    public class Text
    {
        private Text()
        {
            ;
        }
        public static Text getTextInstance()
        {
            return new Text();
        }
        /*
         外科医生模式
         */
        private Dictionary<string, string> Mills = new Dictionary<string, string>();
        /*
         现代的开发模式
         */
        private Dictionary<string, string> GroupModel = new Dictionary<string, string>();
        /*
         设计模式
         */
        private Dictionary<string, string> DesignPatterns = new Dictionary<string, string>();
        /*
         设计原则
         */
        private Dictionary<string, string> DesignPrinciples = new Dictionary<string, string>();

        public  Dictionary<string,string> getMills(){

            Mills.Add("外科医生","亲自定义功能和性能技术说明书，设计程序，编制源代码，测试以及书写技术文档");
            Mills.Add("副手", "作为设计的思考者、讨论者和评估人员.可能编写代码,但对代码的任何部分,不承担具体的开发职责");
            Mills.Add("程序职员", "负责维护编程产品库中所有团队的技术记录");
            Mills.Add("工具维护人员", "开发一些实用的程序,编制具有目录的函数库以及宏库");
            Mills.Add("测试人员", "负责测试用例的编写,计划测试的步骤和为单元测试搭建测试平台");
            return Mills;
        }
        public Dictionary<string, string> getGroupModel()
        {
            GroupModel.Add("项目经理", "相当于该项目的组长,负责把控项目的整体进度,需求的分析,有时也负责代码的编写");
            GroupModel.Add("开发人员", "负责代码的编写,具体可分为前端工程师,后端工程师等");
            GroupModel.Add("测试人员", "负责测试用例的编写,计划测试的步骤和为单元测试搭建测试平台");
            return GroupModel;
        }
        public Dictionary<string, string> getDesignPatterns()
        {
            DesignPatterns.Add("单例模式", "将你的构造方法私有化,就成了最简单的单例模式了！作用是,该类在外界无法在new出其余实例,使得部分操作有且仅有一条途径");
            DesignPatterns.Add("工厂模式", "我也不知道应该怎么描述！请Google一下");
            return DesignPatterns;
        }
        public Dictionary<string, string> getDesignPrinciples()
        {
            DesignPrinciples.Add("单一职责原则", "规定一个类应该只有一个发送变化的原因");
            DesignPatterns.Add("开闭原则", "对扩展开发,对修改关闭.开闭原则是所有代码优化的最终目标,但是需要满足开闭原则还是十分困难的");
            DesignPatterns.Add("迪米特法则", "简单的说就是不和陌生人说话.一个类中不要做其他类的操作");
            return DesignPatterns;
        }
    }
}