﻿using ConsoleGame.Helpers.CrudHelpers;
using ConsoleGame.Managers.Interfaces;
using ConsoleGame.Helpers.DisplayHelpers;

namespace ConsoleGame.Menus;

public class SkillMenu(IInputManager inputManager, IOutputManager outputManager, SkillDisplay skillDisplay, SkillManagement skillManagement)
{
    private readonly IInputManager _inputManager = inputManager;
    private readonly IOutputManager _outputManager = outputManager;
    private readonly SkillDisplay _skillDisplay = skillDisplay;
    private readonly SkillManagement _skillManagement = skillManagement;

    public void SkillMainMenu()
    {
        _outputManager.Clear();
        while (true)
        {
            _outputManager.WriteLine("=== Skill Main Menu ===", ConsoleColor.Cyan);
            _outputManager.WriteLine("1. View Skills"
                + "\n2. Manage Skills"
                + "\n3. Return to Admin Menu");

            var choice = _inputManager.ReadMenuKey(3);
            switch (choice)
            {
                case 1:
                    _skillDisplay.Menu();
                    break;
                case 2:
                    _skillManagement.Menu();
                    break;
                case 3:
                    _outputManager.Clear();
                    return;
            }
        }
    }
}
