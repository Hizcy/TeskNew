using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text;

public partial class StartExam : BasePage//System.Web.UI.Page
{
    public System.Text.StringBuilder sb = new System.Text.StringBuilder();
    public int examNumber = 1;//总题数
    public int r_examNumber = 0;//单选题数
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            if (identity != null)
            {
                List<Task.Entity.tb_TeskQuestionsEntity> list = Task.BLL.tb_TeskQuestionsBLL.GetInstance().Get10TaskQuestion() as List<Task.Entity.tb_TeskQuestionsEntity>;
                if (list != null && list.Count > 0)
                {
                    System.Text.StringBuilder json = new System.Text.StringBuilder();
                    List<Task.Entity.tb_TeskQuestionsEntity> fuxList = new List<Task.Entity.tb_TeskQuestionsEntity>();
                    json.Append("[");
                    foreach (Task.Entity.tb_TeskQuestionsEntity model in list)
                    {
                        #region //单选
                        if (model.QuestionType == 1)
                        {
                            json.Append("{\"title\":\"" + model.Id + "\",\"answer\":\"" + model.Results + "\"},");
                            sb.Append("<div class=\"d-diva\">");
                            sb.Append("<div class=\"d-pad-1\">");
                            sb.Append("<div class=\"position f-fl\">" + examNumber + "</div>");
                            sb.Append("<div class=\"qaDescription f-fl\">");
                            sb.Append("<div class=\"qaCate j-qacate f-fl\">");
                            sb.Append("<span class=\"dan\">单选</span>");
                            sb.Append("</div>");
                            sb.Append("<div class=\"j-richTxt\">");
                            sb.Append("<p><span style=\"font-family: 宋体; font-size: 14px;\">" + model.Title + "</span></p>");
                            sb.Append("</div>");
                            sb.Append("</div>");
                            sb.Append("</div>");
                            sb.Append("<div class=\"d-pad-2\">");

                            sb.Append("<ul>");
                            sb.Append("<li class=\"f-cb\">");
                            sb.Append("<input type=\"radio\" class=\"u-tbi\" style=\"cursor: pointer;\" name=\"op_10022749351464311413298" + examNumber + "\" value=\"A_" + model.Id + "\" />");
                            sb.Append("<div class=\"optionPos f-fl\">A.</div>");
                            sb.Append("<div class=\"f-fl\">");
                            sb.Append("<p style=\"margin-top: 3px;\"><span style=\"font-size: 14px; color: #5c5353; letter-spacing: 2px; margin: 5px;\">" + model.A + "</span></p>");
                            sb.Append("<p>");
                            sb.Append("<br />");
                            sb.Append("</p>");
                            sb.Append("</div>");
                            sb.Append("</li>");

                            sb.Append("<li class=\"f-cb\">");
                            sb.Append("<input type=\"radio\" class=\"u-tbi\" style=\"cursor: pointer;\" name=\"op_10022749351464311413298" + examNumber + "\" value=\"B_" + model.Id + "\" />");
                            sb.Append("<div class=\"optionPos f-fl\">B.</div>");
                            sb.Append("<div class=\"f-fl\">");
                            sb.Append("<p style=\"margin-top: 3px;\"><span style=\"font-size: 14px; color: #5c5353; letter-spacing: 2px; margin: 5px;\">" + model.B + "</span></p>");
                            sb.Append("<p>");
                            sb.Append("<br />");
                            sb.Append("</p>");
                            sb.Append("</div>");
                            sb.Append("</li>");


                            sb.Append("<li class=\"f-cb\">");
                            sb.Append("<input type=\"radio\" class=\"u-tbi\" style=\"cursor: pointer;\" name=\"op_10022749351464311413298" + examNumber + "\" value=\"C_" + model.Id + "\" />");
                            sb.Append("<div class=\"optionPos f-fl\">C.</div>");
                            sb.Append("<div class=\"f-fl\">");
                            sb.Append("<p style=\"margin-top: 3px;\"><span style=\"font-size: 14px; color: #5c5353; letter-spacing: 2px; margin: 5px;\">" + model.C + "</span></p>");
                            sb.Append("<p>");
                            sb.Append("<br />");
                            sb.Append("</p>");
                            sb.Append("</div>");
                            sb.Append("</li>");


                            sb.Append("<li class=\"f-cb\">");
                            sb.Append("<input type=\"radio\" class=\"u-tbi\" style=\"cursor: pointer;\" name=\"op_10022749351464311413298" + examNumber + "\" value=\"D_" + model.Id + "\" />");
                            sb.Append("<div class=\"optionPos f-fl\">D.</div>");
                            sb.Append("<div class=\"f-fl\">");
                            sb.Append("<p style=\"margin-top: 3px;\"><span style=\"font-size: 14px; color: #5c5353; letter-spacing: 2px; margin: 5px;\">" + model.D + "</span></p>");
                            sb.Append("<p>");
                            sb.Append("<br />");
                            sb.Append("</p>");
                            sb.Append("</div>");
                            sb.Append("</li>");
                            if (model.OptionsNubmer == 6)
                            {
                                sb.Append("<li class=\"f-cb\">");
                                sb.Append("<input type=\"radio\" class=\"u-tbi\" style=\"cursor: pointer;\" name=\"op_10022749351464311413298" + examNumber + "\" value=\"E_" + model.Id + "\" />");
                                sb.Append("<div class=\"optionPos f-fl\">E.</div>");
                                sb.Append("<div class=\"f-fl\">");
                                sb.Append("<p style=\"margin-top: 3px;\"><span style=\"font-size: 14px; color: #5c5353; letter-spacing: 2px; margin: 5px;\">" + model.E + "</span></p>");
                                sb.Append("<p>");
                                sb.Append("<br />");
                                sb.Append("</p>");
                                sb.Append("</div>");
                                sb.Append("</li>");

                                sb.Append("<li class=\"f-cb\">");
                                sb.Append("<input type=\"radio\" class=\"u-tbi\" style=\"cursor: pointer;\" name=\"op_10022749351464311413298" + examNumber + "\" value=\"F_" + model.Id + "\" />");
                                sb.Append("<div class=\"optionPos f-fl\">F.</div>");
                                sb.Append("<div class=\"f-fl\">");
                                sb.Append("<p style=\"margin-top: 3px;\"><span style=\"font-size: 14px; color: #5c5353; letter-spacing: 2px; margin: 5px;\">" + model.F + "</span></p>");
                                sb.Append("<p>");
                                sb.Append("<br />");
                                sb.Append("</p>");
                                sb.Append("</div>");
                                sb.Append("</li>");
                            }
                            sb.Append("</ul>");
                            sb.Append("</div>");
                            sb.Append("</div>");

                            sb.Append("<div>");
                            sb.Append("<hr class=\"hr_l\"/>");
                            sb.Append("<div class=\"fanswer\" style=\"display:none\" >");
                            sb.Append("<div  class=\"cla_you" + examNumber + "\"  style=\"position: absolute;margin-top: -55px;margin-left: 30px;color:red;font-weight:bold;font-size:14px\"></div>");
                            sb.Append("<div class=\"cls_answer" + examNumber + "\" style=\"position: absolute;margin-top: -55px;margin-left: 250px;color:#8FC200;font-weight:bold;font-size:14px;display:none\">正确答案：" + model.Results + "</div>");
                            sb.Append("<div class=\"cla_zp" + examNumber + "\" style=\"position: absolute; margin-top: -55px; margin-left: 30px; color: rgb(143, 194, 0); font-weight: bold; font-size: 14px;display:none\">回答正确</div>");
                            sb.Append("</div>");
                            sb.Append("</div>");
                            examNumber++;
                        }
                        #endregion

                        #region //多选放到list
                        else if (model.QuestionType == 2)
                        {
                            fuxList.Add(model);
                        }
                        #endregion
                    }
                    r_examNumber = examNumber;
                    #region //多选
                    if (fuxList != null && fuxList.Count > 0)
                    {
                        foreach (Task.Entity.tb_TeskQuestionsEntity model in fuxList)
                        {
                            json.Append("{\"title\":\"" + model.Id + "\",\"answer\":\"" + model.Results + "\"},");
                            sb.Append("<div class=\"d-diva\">");
                            
                            sb.Append("<div class=\"d-pad-1\">");
                            sb.Append("<div class=\"position f-fl\">" + examNumber + "</div>");
                            sb.Append("<div class=\"qaDescription f-fl\">");
                            sb.Append("<div class=\"qaCate j-qacate f-fl\">");
                            sb.Append("<span class=\"dan\">多选</span>");
                            sb.Append("</div>");
                            sb.Append("<div class=\"j-richTxt\">");
                            sb.Append("<p><span style=\"font-family: 宋体; font-size: 14px;\">" + model.Title.Replace("%20"," ") + "</span></p>");
                            sb.Append("</div>");
                            sb.Append("</div>");
                            sb.Append("</div>");


                            sb.Append("<div class=\"d-pad-2\">");
                            sb.Append("<ul>");
                            sb.Append("<li class=\"f-cb\">");
                            sb.Append("<input type=\"checkbox\" class=\"u-tbi" + examNumber + "\" style=\"cursor: pointer;\" value=\"A_" + model.Id + "\" />");
                            sb.Append("<div class=\"optionPos f-fl\">A.</div>");
                            sb.Append("<div class=\"f-fl\">");
                            sb.Append("<p style=\"margin-top: 3px;\"><span style=\"font-size: 14px; color: #5c5353; letter-spacing: 2px; margin: 5px;\">" + model.A + "</span></p>");
                            sb.Append("<p>");
                            sb.Append("<br />");
                            sb.Append("</p>");
                            sb.Append("</div>");
                            sb.Append("</li>");

                            sb.Append("<li class=\"f-cb\">");
                            sb.Append("<input type=\"checkbox\" class=\"u-tbi" + examNumber + "\" style=\"cursor: pointer;\" value=\"B_" + model.Id + "\" />");
                            sb.Append("<div class=\"optionPos f-fl\">B.</div>");
                            sb.Append("<div class=\"f-fl\">");
                            sb.Append("<p style=\"margin-top: 3px;\"><span style=\"font-size: 14px; color: #5c5353; letter-spacing: 2px; margin: 5px;\">" + model.B + "</span></p>");
                            sb.Append("<p>");
                            sb.Append("<br />");
                            sb.Append("</p>");
                            sb.Append("</div>");
                            sb.Append("</li>"); 

                            sb.Append("<li class=\"f-cb\">");
                            sb.Append("<input type=\"checkbox\" class=\"u-tbi" + examNumber + "\" style=\"cursor: pointer;\"  value=\"C_" + model.Id + "\" />");
                            sb.Append("<div class=\"optionPos f-fl\">C.</div>");
                            sb.Append("<div class=\"f-fl\">");
                            sb.Append("<p style=\"margin-top: 3px;\"><span style=\"font-size: 14px; color: #5c5353; letter-spacing: 2px; margin: 5px;\">" + model.C + "</span></p>");
                            sb.Append("<p>");
                            sb.Append("<br />");
                            sb.Append("</p>");
                            sb.Append("</div>");
                            sb.Append("</li>");


                            sb.Append("<li class=\"f-cb\">");
                            sb.Append("<input type=\"checkbox\" class=\"u-tbi" + examNumber + "\" style=\"cursor: pointer;\"  value=\"D_" + model.Id + "\" />");
                            sb.Append("<div class=\"optionPos f-fl\">D.</div>");
                            sb.Append("<div class=\"f-fl\">");
                            sb.Append("<p style=\"margin-top: 3px;\"><span style=\"font-size: 14px; color: #5c5353; letter-spacing: 2px; margin: 5px;\">" + model.D + "</span></p>");
                            sb.Append("<p>");
                            sb.Append("<br />");
                            sb.Append("</p>");
                            sb.Append("</div>");
                            sb.Append("</li>");
                            if (model.OptionsNubmer == 6)
                            {
                                sb.Append("<li class=\"f-cb\">");
                                sb.Append("<input type=\"checkbox\" class=\"u-tbi" + examNumber + "\" style=\"cursor: pointer;\"  value=\"E_" + model.Id + "\" />");
                                sb.Append("<div class=\"optionPos f-fl\">E.</div>");
                                sb.Append("<div class=\"f-fl\">");
                                sb.Append("<p style=\"margin-top: 3px;\"><span style=\"font-size: 14px; color: #5c5353; letter-spacing: 2px; margin: 5px;\">" + model.E + "</span></p>");
                                sb.Append("<p>");
                                sb.Append("<br />");
                                sb.Append("</p>");
                                sb.Append("</div>");
                                sb.Append("</li>");

                                sb.Append("<li class=\"f-cb\">");
                                sb.Append("<input type=\"checkbox\" class=\"u-tbi" + examNumber + "\" style=\"cursor: pointer;\"  value=\"F_" + model.Id + "\" />");
                                sb.Append("<div class=\"optionPos f-fl\">F.</div>");
                                sb.Append("<div class=\"f-fl\">");
                                sb.Append("<p style=\"margin-top: 3px;\"><span style=\"font-size: 14px; color: #5c5353; letter-spacing: 2px; margin: 5px;\">" + model.F + "</span></p>");
                                sb.Append("<p>");
                                sb.Append("<br />");
                                sb.Append("</p>");
                                sb.Append("</div>");
                                sb.Append("</li>");
                            }
                            sb.Append("</ul>");
                            sb.Append("</div>");
                            sb.Append("</div>");


                            sb.Append("<div>");
                            sb.Append("<hr class=\"hr_l\"/>");
                            sb.Append("<div class=\"fanswer\" style=\"display:none\" >");
                            sb.Append("<div  class=\"cla_you" + examNumber + "\"  style=\"position: absolute;margin-top: -55px;margin-left: 30px;color:red;font-weight:bold;font-size:14px\"></div>");
                            sb.Append("<div class=\"cls_answer" + examNumber + "\" style=\"position: absolute;margin-top: -55px;margin-left: 250px;color:#8FC200;font-weight:bold;font-size:14px;display:none\">正确答案：" + model.Results + "</div>");
                            sb.Append("<div class=\"cla_zp" + examNumber + "\" style=\"position: absolute; margin-top: -55px; margin-left: 30px; color: rgb(143, 194, 0); font-weight: bold; font-size: 14px;display:none\">回答正确</div>");
                            sb.Append("</div>");
                            sb.Append("</div>");
                            examNumber++;
                        }
                    }
                    #endregion
                    string strJson = json.ToString().Substring(0, json.ToString().LastIndexOf(',')) + "]";
                    string path = Request.PhysicalApplicationPath;
                    path += "examresult/examresult_" + identity.UserID + ".txt";
                    if (File.Exists(path))
                    {
                        File.Delete(path);
                    }
                    FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
                    StreamWriter sw = new StreamWriter(fs, Encoding.Default);
                    sw.WriteLine(strJson);
                    sw.Close();
                    fs.Close();
                }

            }
            else
            {
                Response.Redirect("login.aspx");
            }
        }
    }
}