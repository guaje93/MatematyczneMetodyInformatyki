using OxyPlot;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace WpfApp4.ViewModel
{
    class PrismMakerViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Points> points = new ObservableCollection<Points>();
        public ObservableCollection<Points> PointsList
        {
            get
            {
                return points;
            }
            set
            {
                points = value;
                OnPropertyChanged("PointsList");
                UpdatePlot(points);
            }
        }

        public ObservableCollection<DataPoint> points2 = new ObservableCollection<DataPoint>();
        public ObservableCollection<DataPoint> PointsList2
        {
            get
            {
                return points2;
            }
            set
            {
                points2 = value;
                OnPropertyChanged("PointsList2");
            }
        }

        ObservableCollection<Points> editedPoints = new ObservableCollection<Points>();
        public ObservableCollection<Points> EditedPointsList
        {
            get
            {
                return editedPoints;
            }
            set
            {
                editedPoints = value;
                OnPropertyChanged("EditedPointsList");
            }
        }

        ObservableCollection<DataPoint> editedPoints2 = new ObservableCollection<DataPoint>();
        public ObservableCollection<DataPoint> EditedPointsList2
        {
            get
            {
                return editedPoints2;
            }
            set
            {
                editedPoints2 = value;
                OnPropertyChanged("EditedPointsList2");
            }
        }

        private String _property1;
        public String Property1
        {
            get { return _property1; }
            set { _property1 = value; OnPropertyChanged("Property1"); }
        }

        private string translateX;

        public string TranslateX
        {
            get { return translateX; }
            set
            {
                translateX = value;
                OnPropertyChanged("TranslateX");
            }
        }

        private string translateY;

        public string TranslateY
        {
            get { return translateY; }
            set
            {
                translateY = value;
                OnPropertyChanged("TranslateY");
            }
        }

        private string rotateAngle;

        public string RotateAngle
        {
            get { return rotateAngle; }
            set
            {
                rotateAngle = value;
                OnPropertyChanged("RotateAngle");
            }
        }
        private string scaleBasePointX;
        public string ScaleBasePointX
        {
            get { return scaleBasePointX; }
            set
            {
                scaleBasePointX = value;
                OnPropertyChanged("ScaleBasePointX");
            }
        }

        private string scaleBasePointY;
        public string ScaleBasePointY
        {
            get { return scaleBasePointY; }
            set
            {
                scaleBasePointY = value;
                OnPropertyChanged("ScaleBasePointY");
            }
        }

        private string rotateBasePointX;
        public string RotateBasePointX
        {
            get { return rotateBasePointX; }
            set
            {
                rotateBasePointX = value;
                OnPropertyChanged("RotateBasePointX");
            }
        }

        private string rotateBasePointY;
        public string RotateBasePointY
        {
            get { return rotateBasePointY; }
            set
            {
                rotateBasePointY = value;
                OnPropertyChanged("RotateBasePointY");
            }
        }


        private string scale;

        public string Scale
        {
            get { return scale; }
            set { scale = value; }
        }

        private int _choice;

        public int choice
        {
            get { return _choice; }
            set { _choice = value; }
        }

        private string _circuit;

        public string Circuit
        {
            get { return _circuit; }
            set
            {
                _circuit = value;
                OnPropertyChanged("Circuit");
            }
        }

        private string _area;

        public string Area
        {
            get { return _area; }
            set
            {
                _area = value;
                OnPropertyChanged("Area");
            }
        }
        private string _circuit2;

        public string Circuit2
        {
            get { return _circuit2; }
            set
            {
                _circuit2 = value;
                OnPropertyChanged("Circuit2");
            }
        }

        private string _area2;

        public string Area2
        {
            get { return _area2; }
            set
            {
                _area2 = value;
                OnPropertyChanged("Area2");
            }
        }
        // Create the OnPropertyChanged method to raise the event
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public void UpdatePlot(ObservableCollection<Points> PointsList)
        {

            PointsList2.Clear();
            foreach (var item in PointsList)
            {
                PointsList2.Add(new DataPoint(item.X, item.Y));
            }
            PointsList2.Add(new DataPoint(PointsList[0].X, PointsList[0].Y));

            EditedPointsList.Clear();
            foreach (var item in PointsList)
            {
                EditedPointsList.Add(new Points(item.X, item.Y));
            }
        }

        private ICommand _clickCommand;
        public ICommand ClickCommand
        {
            get
            {
                if (_clickCommand == null)
                {
                    _clickCommand = new RelayCommand(
                        param => this.Click()
                    );
                }
                return _clickCommand;
            }
        }

        private void Click()
        {
            UpdatePlot(points);
            UpdateEditedPlot();
            SetCircuit();
            SetArea();
        }

        private void UpdateEditedPlot()
        {
            switch (Property1)
            {
                case "Translate": { translating(); break; }
                case "Rotate": { rotating(); break; }
                case "Scale": { scaling(); break; }
            }
        }

        public void translating()
        {
            EditedPointsList2.Clear();
            EditedPointsList.Clear();


            foreach (var item in points2)
            {
                EditedPointsList2.Add(new DataPoint(Math.Round(item.X + Convert.ToDouble(TranslateX), 3), Math.Round(item.Y + Convert.ToDouble(TranslateY), 3)));
            }

            foreach (var item in points)
            {
                EditedPointsList.Add(new Points(Math.Round(item.X + Convert.ToDouble(TranslateX), 3), Math.Round(item.Y + Convert.ToDouble(TranslateY), 3)));
            }
        }
        public void rotating()
        {
            EditedPointsList2.Clear();
            EditedPointsList.Clear();

            foreach (var item in points2)
            {
                EditedPointsList2.Add(new DataPoint(Math.Round((item.X - Convert.ToDouble(RotateBasePointX)) * Math.Cos(Convert.ToDouble(RotateAngle) * Math.PI / 180) - (item.Y - Convert.ToDouble(RotateBasePointY)) * Math.Sin(Convert.ToDouble(RotateAngle) * Math.PI / 180) + Convert.ToDouble(RotateBasePointX), 3), Math.Round((item.X - Convert.ToDouble(RotateBasePointX)) * Math.Sin(Convert.ToDouble(RotateAngle) * Math.PI / 180) + (item.Y - Convert.ToDouble(RotateBasePointY)) * Math.Cos(Convert.ToDouble(RotateAngle) * Math.PI / 180) + Convert.ToDouble(RotateBasePointY), 3)));

            }

            foreach (var item in points)
            {
                EditedPointsList.Add(new Points(Math.Round((item.X - Convert.ToDouble(RotateBasePointX)) * Math.Cos(Convert.ToDouble(RotateAngle) * Math.PI / 180) - (item.Y - Convert.ToDouble(RotateBasePointY)) * Math.Sin(Convert.ToDouble(RotateAngle) * Math.PI / 180) + Convert.ToDouble(RotateBasePointX), 3), Math.Round((item.X - Convert.ToDouble(RotateBasePointX)) * Math.Sin(Convert.ToDouble(RotateAngle) * Math.PI / 180) + (item.Y - Convert.ToDouble(RotateBasePointY)) * Math.Cos(Convert.ToDouble(RotateAngle) * Math.PI / 180) + Convert.ToDouble(RotateBasePointY), 3)));
            }
        }
        public void scaling()
        {
            EditedPointsList2.Clear();
            EditedPointsList.Clear();

            foreach (var item in points2)
            {
                EditedPointsList2.Add(new DataPoint(Math.Round((item.X - Convert.ToDouble(ScaleBasePointX)) * Convert.ToDouble(Scale) + Convert.ToDouble(ScaleBasePointX), 3), Math.Round((item.Y - Convert.ToDouble(ScaleBasePointY)) * Convert.ToDouble(Scale) + Convert.ToDouble(ScaleBasePointY), 3)));
            }

            foreach (var item in points)
            {
                EditedPointsList.Add(new Points(Math.Round((item.X - Convert.ToDouble(ScaleBasePointX)) * Convert.ToDouble(Scale) + Convert.ToDouble(ScaleBasePointX), 3), Math.Round((item.Y - Convert.ToDouble(ScaleBasePointY)) * Convert.ToDouble(Scale) + Convert.ToDouble(ScaleBasePointY), 3)));
            }
        }

        public void SetCircuit()
        {
            double circuit = 0;
            for (int i = 1; i < PointsList2.Count; i++)
            {
                circuit += Math.Sqrt(Math.Pow((PointsList2[i].X - PointsList2[i - 1].X), 2) + Math.Pow((PointsList2[i].Y - PointsList2[i - 1].Y), 2));
            }

            double editedCircuit = 0;
            for (int i = 1; i < EditedPointsList2.Count; i++)
            {
                editedCircuit += Math.Sqrt(Math.Pow((EditedPointsList2[i].X - EditedPointsList2[i - 1].X), 2) + Math.Pow((EditedPointsList2[i].Y - EditedPointsList2[i - 1].Y), 2));
            }

            Circuit = Math.Round(circuit, 3).ToString();
            Circuit2 = Math.Round(editedCircuit, 3).ToString();
        }


        public void SetArea()
        {
            double area = 0;
            for (int i = 0; i < PointsList2.Count - 1; i++)
            {
                area += (PointsList2[i].X * PointsList2[i + 1].Y - PointsList2[i + 1].X * PointsList2[i].Y) / 2;
            }

            double editedArea = 0;
            for (int i = 0; i < EditedPointsList2.Count - 1; i++)
            {
                editedArea += (EditedPointsList2[i].X * EditedPointsList2[i + 1].Y - EditedPointsList2[i + 1].X * EditedPointsList2[i].Y) / 2;
            }

            Area = Math.Abs(Math.Round(area, 3)).ToString();
            Area2 = Math.Abs(Math.Round(editedArea, 3)).ToString();
        }
    }
}
