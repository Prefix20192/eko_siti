﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ООО__ЭКО_Сити_
{
    public partial class vacancy_main : Form
    {
        public vacancy_main()
        {
            InitializeComponent();
        }


        private void button_sort_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Обязанности: сортировка бытового мусора для дальнейшей переработки.\nТребования: без опыта работы.\nУсловия:\nОформление согласно ТК РФ.\nВесь соцпакет.\nДостойная заработная плата.\nСменный график работы, выходные дни по скользящему графику.\nДоставка транспортом организации - Михайловск, Пелагиада, Ставрополь, Московское, Подлужное, Труновское, Донское, Казинка, Тугулук, Кугульта.");
        }

        private void button_driver_pogruz_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Обязанности: управление погрузчиком, перемещение грузов по территории организации.\n\nТребования:\nПрава тракториста.Обязательно документ об обучении на водителя погрузчика, водительская медицинская справка.\nЖелательно опыт работы.\n\nУсловия:\nОформление согласно ТК РФ.\nВесь соцпакет.\nДостойная заработная плата.\nСменный график работы, выходные дни по скользящему графику.\nДоставка транспортом организации - Михайловск, Пелагиада, Ставрополь, Московское, Подлужное, Труновское, Донское, Казинка, Тугулук, Кугульта.");
        }

        private void button_uri_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Обязанности:\nСоставление нормативно - правовых документов\nПретензионно - исковая работа\nПредставление интересов организации в суде\nОбеспечение соблюдения требования законодательства в деятельности организации\n\nТребования:\nОтличное знание законодательства Российской Федерации\nЮридическое образование и опыт юридической работы обязателен\n\nУсловия:\nОформление согласно ТК РФ\nВесь соцпакет\nДостойная заработная плата\nГрафик 5 / 2, выходные дни  сб.и вс.");
        }

        private void button_ekonom_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Обязанности:\nВедение учета экономических показателей результатов производственной деятельности организации и его подразделений, учет заключенных договоров.\nПодготовка расчетов по материальным, трудовым и финансовым затратам, подготовка отчетности в установленные сроки.\n\nТребования:\nЗнание законодательных и нормативных правовых актов, методических материалов по планированию, учету и анализу.\nОпыт работы экономиста обязателен.\n\nУсловия:\nОформление согласно ТК РФ.\nВесь соцпакет.\nДостойная заработная плата.\nГрафик работы 5/2, выходные дни суббота и воскресенье.");
        }

        private void button_raboch_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Обязанности: \nРабота по обслуживанию полигона\nСортировка бытового мусора для дальнейшей переработки\nТребования: без опыта работы.\nУсловия:\nОформление согласно ТК РФ.\nВесь соцпакет.\nДостойная заработная плата.\nСменный график работы, выходные дни по скользящему графику.\nДоставка транспортом организации - Михайловск, Пелагиада, Ставрополь, Московское, Подлужное,\n\nТруновское, Донское, Казинка, Тугулук, Кугульта");
        }

        private void button_operator_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Обязанности: \nНастройка режимов работы конвейера.\nРегулирование хода производственного процесса.\nУправление и обеспечение бесперебойного функционирования оборудования.\nТребования:\nСреднее профессиональное образование.\nЖелательно опыт работы.\nУсловия:\nОформление согласно ТК РФ.\nВесь соцпакет.\nДостойная заработная плата.\nСменный график работы, выходные дни по скользящему графику.\nДоставка транспортом организации - Михайловск, Пелагиада, Ставрополь, Московское, Подлужное, Труновское, Донское, Казинка, Тугулук, Кугульта");
        }

        private void button_slesar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Обязанности: ремонт технологического оборудования, автотранспортных средств.\n\nТребования:\nСреднее профессиональное образование.\nЖелательно опыт работы.\n\nУсловия:\nОформление согласно ТК РФ.\nВесь соцпакет.\nДостойная заработная плата.\nСменный график работы, выходные дни по скользящему графику.\nДоставка транспортом организации - Михайловск, Пелагиада, Ставрополь, Московское, Подлужное, Труновское, Донское, Казинка, Тугулук, Кугульта.");
        }

        private void button_driver_gruz_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Обязанности:\nУправление грузовыми автомобилями.\nСоблюдение правил дорожного движения и правил технической эксплуатации автомобилей.\n\nТребования:\nОпыт работы обязателен.\nПрава категории С, Е.\n\nУсловия:\nОформление согласно ТК РФ.\nВесь соцпакет.\nДостойная заработная плата.\nСменный график работы, выходные дни по скользящему графику.\nДоставка транспортом организации - Михайловск, Пелагиада, Ставрополь, Московское, Подлужное, Труновское, Донское, Казинка, Тугулук, Кугульта.");
        }
    }
}