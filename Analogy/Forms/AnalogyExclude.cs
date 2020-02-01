using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Analogy
{

    public partial class AnalogyExclude : Form
    {
        private class AnalogyCheckListItem
        {
            internal string Text { get; }
            private int Count { get; }

            public AnalogyCheckListItem(string text, int count)
            {
                Text = text;
                Count = count;
            }

            public override string ToString()
            {
                return $" {nameof(Count)} {Count}: {Text}";
            }
        }

        public static List<string> GlobalExclusion = new List<string>();
        public AnalogyExclude()
        {
            InitializeComponent();
        }

        public AnalogyExclude(List<string> items, List<string> excludeMostCommon) : this()
        {
            var group = items.GroupBy(i => i).OrderByDescending(i => i.Count());
            foreach (IGrouping<string, string> grouping in group)
            {

                bool checkedItem = excludeMostCommon.Contains(grouping.Key);
                checkedListBox1.Items.Add(new AnalogyCheckListItem(grouping.Key, grouping.Count()), checkedItem);
            }
        }



        private void btnTop10_Click(object sender, EventArgs e)
        {
            int length = Math.Min(10, checkedListBox1.Items.Count);
            for (int i = 0; i < length; i++)
            {
                checkedListBox1.SetItemCheckState(i, CheckState.Checked);
            }
        }

        private void sBtnOk_Click(object sender, EventArgs e)
        {
            //todo check casting
            GlobalExclusion = checkedListBox1.CheckedItems.Cast<AnalogyCheckListItem>().Select(i => FilterCriteriaObject.EscapeLikeValue(i.Text)).ToList();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void sBtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            foreach (int i in checkedListBox1.CheckedIndices)
            {
                checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
            }
        }
    }

    public class SqlParser
    {
        public List<string> Parse(string sql)
        {
            //TSql100Parser parser = new TSql100Parser(false);
            //IScriptFragment fragment;
            //IList<ParseError> errors;
            //fragment = parser.Parse(new StringReader(sql), out errors);
            //if (errors != null && errors.Count > 0)
            //{
            //    List<string> errorList = new List<string>();
            //    foreach (var error in errors)
            //    {
            //        errorList.Add(error.Message);
            //    }
            //    return errorList;
            //}
            return null;
        }
    }
}
