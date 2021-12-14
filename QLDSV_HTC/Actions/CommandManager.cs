using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_HTC.Actions
{
    public class CommandManager
    {
        private Stack<Action> undoStack;
        private Stack<Action> redoStack;
        private BarButtonItem btnUndo;
        private BarButtonItem btnRedo;

        public CommandManager(BarButtonItem btnUndo, BarButtonItem btnRedo)
        {
            undoStack = new Stack<Action>();
            redoStack = new Stack<Action>();
            this.btnUndo = btnUndo;
            this.btnRedo = btnRedo;
            Display();
        }

        public void Display()
        {
            btnUndo.Enabled = undoStack.Count > 0;
            btnRedo.Enabled = redoStack.Count > 0;
        }

        public Action RemoveLastUndoNode()
        {
            return undoStack.Pop();
        }

        public Action GetLastUndoNode()
        {
            return undoStack.Peek();
        }

        public int GetUndoStackSize()
        {
            return undoStack.Count;
        }

        public int GetRedoStackSize()
        {
            return redoStack.Count;
        }

        public void Add(Action action)
        {
            undoStack.Push(action);
            Display();
        }

        public void Undo()
        {
            Action action = undoStack.Pop();
            action.Undo();           
            redoStack.Push(action);
            Display();
        }

        public void Redo()
        {
            Action action = redoStack.Pop();
            action.Redo();
            undoStack.Push(action);
            Display();
        }

        public void Clear()
        {
            undoStack.Clear();
            redoStack.Clear();
            Display();
        }
    }
}
